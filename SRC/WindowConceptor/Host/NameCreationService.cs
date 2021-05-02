using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;

namespace WindowConceptor.Host
{
    /// <summary>
    /// This is responsible for naming the components as they are created.
    /// This is added as a servide by the HostSurfaceManager
    /// </summary>
    public class NameCreationService : INameCreationService
    {
        public NameCreationService()
        {
        }

        string INameCreationService.CreateName(IContainer container, Type type)
        {
            var cc = container.Components;
            int min = int.MaxValue;
            int max = int.MinValue;
            int count = 0;
            for (int i = 0, loopTo = cc.Count - 1; i <= loopTo; i++)
            {
                Component comp = cc[i] as Component;
                if (ReferenceEquals(comp.GetType(), type))
                {
                    count += 1;
                    string name = comp.Site.Name;
                    if (name.StartsWith(type.Name))
                    {
                        try
                        {
                            int value = int.Parse(name.Substring(type.Name.Length));
                            if (value < min)
                                min = value;
                            if (value > max)
                                max = value;
                        }
                        catch (Exception ex)
                        {
                            Trace.WriteLine(ex.ToString());
                        }
                    }
                }
            } // for

            if (count == 0)
            {
                return type.Name + "1";
            }
            else if (min > 1)
            {
                int j = min - 1;
                return type.Name + j.ToString();
            }
            else
            {
                int j = max + 1;
                return type.Name + j.ToString();
            }
        }

        bool INameCreationService.IsValidName(string name)
        {
            return true;
        }

        void INameCreationService.ValidateName(string name)
        {
            return;
        }
    } // class
} // namespace
