using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace cwc
{
    class Str{
        public static string fSubStr(string _sInput, int _nBegin, int _nEnd){
           return _sInput.Substring(_nBegin, _nEnd - _nBegin);
        }
        public static string fSubStr(string _sInput, int _nBegin, string _sEnd){
            int _nIndex = _sInput.IndexOf(_sEnd);
            if(_nIndex >= 0){
                 return _sInput.Substring(_nBegin, _nIndex - _nBegin);
            }
            return _sInput.Substring(_nBegin);
        }
         public static string fSubStr(string _sInput, string _sBegin, string _sEnd){
            string _sResult = fSubStr(_sInput, 0, _sEnd);
            int _nIndex = _sInput.IndexOf(_sResult);
            if(_nIndex >= 0){
                 return _sResult.Substring(_nIndex+ _sBegin.Length);
            }
            return _sResult;
        }

         public static string fSubStr(string _sInput, string _sBegin){
            int _nIndex = _sInput.IndexOf(_sBegin);
            if(_nIndex >= 0){
                 return _sInput.Substring(_nIndex + _sBegin.Length);
            }
            return _sBegin;
        }

         public static string fGetExtention(string _sPath, bool _bToLower = true){
            int _nIndex = _sPath.LastIndexOf(".");
            if(_nIndex >= 0){
                string _sExt = _sPath.Substring(_nIndex + 1);
                 if(_sExt.IndexOf('/') == -1 && _sExt.IndexOf('\\') == -1) {
                    if(_bToLower) {
                        return _sExt.ToLower();
                    }else {
                        return _sExt;
                    }
                }
            }
            return "";
        }
    }
}
