﻿using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Windows.Forms;

namespace WindowConceptor.Host
{
    public enum LoaderType
    {
        BasicDesignerLoader = 1,
        CodeDomDesignerLoader = 2,
        NoLoader = 3
    }


    /// <summary>
    /// Manages numerous HostSurfaces. Any services added to HostSurfaceManager
    /// will be accessible to all HostSurfaces
    /// </summary>
    public class HostSurfaceManager : DesignSurfaceManager
    {
        public HostSurfaceManager() : base()
        {
            AddService(typeof(INameCreationService), new NameCreationService());

            ActiveDesignSurfaceChanged += new ActiveDesignSurfaceChangedEventHandler(HostSurfaceManager_ActiveDesignSurfaceChanged);
        }

        protected override DesignSurface CreateDesignSurfaceCore(IServiceProvider parentProvider)
        {
            return new HostSurface(parentProvider);
        }


        /// <summary>
        /// Gets a new HostSurface and loads it with the appropriate type of
        /// root component.
        /// </summary>
        private HostControl3 GetNewHost(Type rootComponentType)
        {
            HostSurface hostSurface = (HostSurface)CreateDesignSurface(ServiceContainer);
            if (ReferenceEquals(rootComponentType, typeof(Form)))
            {
                hostSurface.BeginLoad(typeof(Form));
            }
            else if (ReferenceEquals(rootComponentType, typeof(UserControl)))
            {
                hostSurface.BeginLoad(typeof(UserControl));
            }
            else if (ReferenceEquals(rootComponentType, typeof(Component)))
            {
                hostSurface.BeginLoad(typeof(Component));
            }
            else if (ReferenceEquals(rootComponentType, typeof(MyTopLevelComponent2)))
            {
                hostSurface.BeginLoad(typeof(MyTopLevelComponent2));
            }
            else
            {
                throw new Exception("Undefined Host Type: " + rootComponentType.ToString());
            }

            hostSurface.Initialize();
            ActiveDesignSurface = hostSurface;
            return new HostControl3(hostSurface);
        }


        /// <summary>
        /// Gets a new HostSurface and loads it with the appropriate type of
        /// root component. Uses the appropriate Loader to load the HostSurface.
        /// </summary>
        public HostControl3 GetNewHost(Type rootComponentType, LoaderType loaderType)
        {
            if (loaderType == LoaderType.NoLoader)
                return GetNewHost(rootComponentType);
            HostSurface hostSurface = (HostSurface)CreateDesignSurface(ServiceContainer);
            IDesignerHost host = (IDesignerHost)hostSurface.GetService(typeof(IDesignerHost));
            switch (loaderType)
            {
                case LoaderType.BasicDesignerLoader:
                    {
                        var basicHostLoader = new Loader.BasicHostLoader(rootComponentType);
                        hostSurface.BeginLoad(basicHostLoader);
                        hostSurface.Loader = basicHostLoader;

                        break;
                    }

            

                default:
                    {
                        throw new Exception("Loader is not defined: " + loaderType.ToString());
                        break;
                    }
            }

            hostSurface.Initialize();
            return new HostControl3(hostSurface);
        }


        /// <summary>
        /// Opens an Xml file and loads it up using BasicHostLoader (inherits from
        /// BasicDesignerLoader)
        /// </summary>
        public HostControl3 GetNewHost(string fileName)
        {
            if (Equals(fileName, null) || !File.Exists(fileName))
                MessageBox.Show("FileName is incorrect: " + fileName);
            var loaderType = LoaderType.NoLoader;
            if (fileName.EndsWith("osm"))
                loaderType = LoaderType.BasicDesignerLoader;
            if (loaderType == LoaderType.NoLoader || loaderType == LoaderType.CodeDomDesignerLoader)
            {
                throw new Exception("File cannot be opened. Please check the type or extension of the file. Supported format is Xml");
            }

            HostSurface hostSurface = (HostSurface)CreateDesignSurface(ServiceContainer);
            IDesignerHost host = (IDesignerHost)hostSurface.GetService(typeof(IDesignerHost));

            //  
            var basicHostLoader = new Loader.BasicHostLoader(fileName);
            hostSurface.BeginLoad(basicHostLoader);
            hostSurface.Loader = basicHostLoader;

            hostSurface.Initialize();
            return new HostControl3(hostSurface);
        }

        public void AddService(Type type, object serviceInstance)
        {
            ServiceContainer.AddService(type, serviceInstance);
        }


        /// <summary>
        /// Uses the OutputWindow service and writes out to it.
        /// </summary>
        private void HostSurfaceManager_ActiveDesignSurfaceChanged(object sender, ActiveDesignSurfaceChangedEventArgs e)
        {
            // Dim o As ToolWindows.OutputWindow = TryCast(GetService(GetType(ToolWindows.OutputWindow)), ToolWindows.OutputWindow)
            // o.RichTextBox.Text += "New host added." & Microsoft.VisualBasic.Constants.vbLf
        }
    } // class
} // namespace