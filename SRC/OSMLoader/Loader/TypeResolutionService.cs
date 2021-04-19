using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Reflection;
using System.Windows.Forms;

namespace OSMLoader.Loader
{
    /// <summary>
    /// This service resolved the types and is required when using the
    /// CodeDomHostLoader
    /// </summary>
    public class TypeResolutionService : ITypeResolutionService
    {
        private Hashtable ht = new Hashtable();

        public TypeResolutionService()
        {
        }

        public Assembly GetAssembly(AssemblyName name)
        {
            return GetAssembly(name, true);
        }

        public Assembly GetAssembly(AssemblyName name, bool throwOnErrors)
        {
            return Assembly.GetAssembly(typeof(Form));
        }

        public string GetPathOfAssembly(AssemblyName name)
        {
            return null;
        }

        public Type GetType(string name)
        {
            return GetType(name, true);
        }

        public Type GetType(string name, bool throwOnError)
        {
            return GetType(name, throwOnError, false);
        }


        /// <summary>
        /// This method is called when dropping controls from the toolbox
        /// to the host that is loaded using CodeDomHostLoader. For
        /// simplicity we just go through System.Windows.Forms assembly
        /// </summary>
        public Type GetType(string name, bool throwOnError, bool ignoreCase)
        {
            if (ht.ContainsKey(name))
                return (Type)ht[name];
            var winForms = Assembly.GetAssembly(typeof(Button));
            var types = winForms.GetTypes();
            string typeName = string.Empty;
            foreach (var type in types)
            {
                typeName = "system.windows.forms." + type.Name.ToLower();
                if (Equals(typeName, name.ToLower()))
                {
                    ht[name] = type;
                    return type;
                }
            }

            return Type.GetType(name);
        }

        public void ReferenceAssembly(AssemblyName name)
        {
        }
    } // class
} // namespace
