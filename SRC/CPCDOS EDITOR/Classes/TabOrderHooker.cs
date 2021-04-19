using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;

namespace OSMaker.pF.DesignSurfaceExt
{
    public class TabOrderHooker
    {
        private const string _Name_ = "TabOrderHooker";
        private object _tabOrder = null;

        public void HookTabOrder(IDesignerHost host)
        {
            const string _signature_ = _Name_ + "::ctor()";
            if (host.RootComponent is null)
                throw new Exception(_signature_ + " - Exception: the TabOrder must be invoked after the DesignSurface has been loaded!");
            try
            {
                var designAssembly = Assembly.Load("System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
                var tabOrderType = designAssembly.GetType("System.Windows.Forms.Design.TabOrder");
                if (_tabOrder is null)
                {
                    _tabOrder = Activator.CreateInstance(tabOrderType, new object[] { host });
                }
                else
                {
                    DisposeTabOrder();
                }
            }
            catch (Exception exx)
            {
                Debug.WriteLine(exx.Message);
                if (exx.InnerException is object)
                    Debug.WriteLine(exx.InnerException.Message);
                throw;
            }
        }

        public void DisposeTabOrder()
        {
            if (_tabOrder is null)
                return;
            try
            {
                var designAssembly = Assembly.Load("System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
                var tabOrderType = designAssembly.GetType("System.Windows.Forms.Design.TabOrder");
                tabOrderType.InvokeMember("Dispose", BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, _tabOrder, new object[] { true });
                _tabOrder = null;
            }
            catch (Exception exx)
            {
                Debug.WriteLine(exx.Message);
                if (exx.InnerException is object)
                    Debug.WriteLine(exx.InnerException.Message);
                throw;
            }
        }
    }
}