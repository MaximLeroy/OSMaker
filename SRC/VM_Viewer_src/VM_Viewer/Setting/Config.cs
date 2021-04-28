using cwc.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static cwc.Config;

namespace cwc
{

    public class Config : FileUtils
    {

        public class oStringPair
        {
            public oStringPair(string _sKey, string _sValue)
            {
                sKey = _sKey;
                sValue = _sValue;
            }
            public string sKey = "";
            public string sValue = "";
        };


        public Point vStartPos;
        public Size vStartSize;
        public Point vTest;
        public oStringPair[] aOption;

        public bool bTreePrjOpen = false;
        public bool bMaximize;

        public List<string> aRecent;
       
        private XmlDocument oSaveXml;




        string sCurrentFile = "";
        


        internal void fAddRecent(string _sPath)
        {
            _sPath = PathHelper.fNormalizePath(_sPath);
            int _nCount = 0;
            foreach (string _sRecent in aRecent)
            {
                if (_sPath == _sRecent)
                {
                    aRecent.RemoveAt(_nCount);
                    break;
                }
                _nCount++;
            }

            aRecent.Insert(0, _sPath);

            if (aRecent.Count > 20)
            {//Max
                aRecent.RemoveAt(aRecent.Count - 1);
            }
            if (Data.oGui != null && Data.oGui.bCreated)
            {
                Data.oGui.fLoadRecent();
            }
        }

        public bool fTestBool(string _sVal)
        {
            if (_sVal == "True")
            {
                return true;
            }
            return false;
        }

        public void fLoad()
        {
            XmlDocument _oXml = fReadXmlFile();
            if (_oXml == null || _oXml.DocumentElement == null)
            {
                Console.WriteLine("Filw is Null: " + sFile);
                return;
            }
            //oReadXml = _oXml;
            foreach (XmlNode _oNode in _oXml.DocumentElement.ChildNodes)
            {
                switch (_oNode.Name)
                {
                    case "vStartPos":
                        foreach (XmlAttribute _oAtt in _oNode.Attributes)
                        {
                            switch (_oAtt.Name)
                            {
                                case "X":
                                    {
                                        int _nOut = 0; Int32.TryParse(_oAtt.Value, out _nOut);
                                        vStartPos.X = _nOut;
                                    }; break;
                                case "Y":
                                    {
                                        int _nOut = 0; Int32.TryParse(_oAtt.Value, out _nOut);
                                        vStartPos.Y = _nOut;
                                    }; break;
                            }
                        }
                        break;
                    case "vStartSize":
                        foreach (XmlAttribute _oAtt in _oNode.Attributes)
                        {
                            switch (_oAtt.Name)
                            {
                                case "Height":
                                    {
                                        int _nOut = 0; Int32.TryParse(_oAtt.Value, out _nOut);
                                        vStartSize.Height = _nOut;
                                    }; break;
                                case "Width":
                                    {
                                        int _nOut = 0; Int32.TryParse(_oAtt.Value, out _nOut);
                                        vStartSize.Width = _nOut;
                                    }; break;
                            }
                        }
                        break;
                    case "bTreePrjOpen":
                        foreach (XmlAttribute _oAtt in _oNode.Attributes)
                        {
                            switch (_oAtt.Name)
                            {
                                case "Val": { bTreePrjOpen = fTestBool(_oAtt.Value); }; break;
                            }
                        }
                        break;
                    case "bMaximize":
                        foreach (XmlAttribute _oAtt in _oNode.Attributes)
                        {
                            switch (_oAtt.Name)
                            {
                                case "Val": { bMaximize = fTestBool(_oAtt.Value); }; break;
                            }
                        }
                        break;

                    case "RecentList":
                        {
                            foreach (XmlNode _oSubNode in _oNode.ChildNodes)
                            {
                                switch (_oSubNode.Name)
                                {
                                    case "Recent":
                                        fExtractRecent(_oSubNode);
                                        break;
                                }
                            }
                        }
                        break;
                    case "ElementList":
                        {
                            foreach (XmlNode _oSubNode in _oNode.ChildNodes)
                            {
                                switch (_oSubNode.Name)
                                {
                                    case "Elm":
                                        fExtractElement(_oSubNode);
                                        break;
                                }
                            }
                        }
                        break;

                }
            }
        }

        private void fExtractElement(XmlNode _oNode)
        {
            string _sName = "";
            string _sVal = "";
            foreach (XmlAttribute _oAtt in _oNode.Attributes)
            {
                switch (_oAtt.Name)
                {
                    case "Name":
                        _sName = _oAtt.Value;
                        break;
                    case "Val":
                        _sVal = _oAtt.Value; ;
                        break;
                }
            }
            if (!Data.aOption.ContainsKey(_sName))
            {
                Data.aOption.Add(_sName, _sVal);
            }
            else
            {
                Data.aOption[_sName] = _sVal;
            }

        }

        private void fExtractRecent(XmlNode _oNode)
        {
            foreach (XmlAttribute _oAtt in _oNode.Attributes)
            {
                switch (_oAtt.Name)
                {
                    case "Path":
                        aRecent.Add(_oAtt.Value);
                        break;
                }
            }
        }

        internal void fSave()
        {

            if (!bSettingLoaded) { return; } //Loaded at less 1 time
            oSaveXml = new XmlDocument();
            XmlNode _oRootNode = oSaveXml.CreateNode(XmlNodeType.Element, "Config", null);
            oSaveXml.AppendChild(_oRootNode);

            fWriteSubNodes(_oRootNode);

            {
                XmlNode _oXmlNode = oSaveXml.CreateNode(XmlNodeType.Element, "RecentList", null);
                _oRootNode.AppendChild(_oXmlNode);

                foreach (string _sRecent in aRecent)
                {
                    XmlElement _oRecent = oSaveXml.CreateElement("Recent"); _oXmlNode.AppendChild(_oRecent);
                    fCreateAtt(_oRecent, "Path", _sRecent);
                }
            }
            {
                XmlNode _oXmlNode = oSaveXml.CreateNode(XmlNodeType.Element, "ElementList", null);
                _oRootNode.AppendChild(_oXmlNode);

                foreach (KeyValuePair<string, string> _oKey in Data.aOption)
                {
                    XmlElement _oRecent = oSaveXml.CreateElement("Elm"); _oXmlNode.AppendChild(_oRecent);
                    fCreateAtt(_oRecent, "Name", _oKey.Key);
                    fCreateAtt(_oRecent, "Val", _oKey.Value);
                }
            }

            /*
            aOption = new oStringPair[Data.aOption.Count];
            int i =0;
            foreach (KeyValuePair<string, string> _oKey in Data.aOption) {
                aOption[i] = new oStringPair(_oKey.Key, _oKey.Value);
                i++;
            }
            */

            fSaveXmlFile(oSaveXml);
        }

        public XmlAttribute fCreateAtt(XmlElement _oNode, string _sName, string _sValue)
        {
            XmlAttribute _oAtt = oSaveXml.CreateAttribute(_sName);
            _oAtt.Value = _sValue;
            _oNode.Attributes.Append(_oAtt);
            return _oAtt;
        }

        private void fWriteSubNodes(XmlNode _oXmlNode)
        {
            {
                XmlElement _oElm = oSaveXml.CreateElement("vStartPos"); _oXmlNode.AppendChild(_oElm);
                fCreateAtt(_oElm, "X", vStartPos.X.ToString());
                fCreateAtt(_oElm, "Y", vStartPos.Y.ToString());
            }
            {
                XmlElement _oElm = oSaveXml.CreateElement("vStartSize"); _oXmlNode.AppendChild(_oElm);
                fCreateAtt(_oElm, "Width", vStartSize.Width.ToString());
                fCreateAtt(_oElm, "Height", vStartSize.Height.ToString());
            }

            //   public bool bTreePrjOpen = false;
            //  public bool bMaximize ;
            {
                XmlElement _oElm = oSaveXml.CreateElement("bTreePrjOpen"); _oXmlNode.AppendChild(_oElm);
                fCreateAtt(_oElm, "Val", bTreePrjOpen.ToString());
            }
            {
                XmlElement _oElm = oSaveXml.CreateElement("bMaximize"); _oXmlNode.AppendChild(_oElm);
                fCreateAtt(_oElm, "Val", bMaximize.ToString());
            }
        }

        /*
                public Point StartPos
                {
                    get { return vStartPos; }
                    set { vStartPos = value; }
                }

                public Size StartSize
                {
                    get { return vStartSize; }
                    set { vStartSize = value; }
                }*/
    }


    public class ConfigMng
    {
        public static Config oConfig = new Config();
        public static bool bNewConfig = false;
        public static bool bLoadFailed = false;
        private string m_sConfigFileName = PathHelper.GetExeDirectory() + "config.xml";
  


        public Config Config
        {
            get { return oConfig; }
            set { oConfig = value; }
        }


        // Load configuration file
        public void LoadConfig(Form _oForm )
        {
            if (oConfig.aRecent == null)
            {
                oConfig.aRecent = new List<string>();
            }

            if (oConfig.fIniFile(m_sConfigFileName, false, false))
            {
                oConfig.fLoad();
               
                    if (oConfig.vStartPos != null)
                    {
                    _oForm.Location = oConfig.vStartPos;
                    }
                    if (oConfig.vStartSize != null)
                    {
                    _oForm.Size = oConfig.vStartSize;
                    }

            }else {
                bLoadFailed = true;
            }
            //.fSetNewFile(m_sConfigFileName);

            if (oConfig.vStartSize.Height == 0 && oConfig.vStartSize.Width == 0)
            {
                bLoadFailed = true;
            }

            bNewConfig = true;


            if (oConfig.aOption == null)
            {
                oConfig.aOption = new oStringPair[0];
            }
            foreach (oStringPair _oVal in oConfig.aOption)
            {
                Data.aOption[_oVal.sKey] = _oVal.sValue;
            }

        }

        // Save configuration file
        public void SaveConfig()
        {

            oConfig.fSave();
        }
    }
}
