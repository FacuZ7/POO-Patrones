using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Singleton
{
    public sealed class Log
    {
        private static Log _instance;
        private string path;

        public static Log GetInstance(string path)
        {
            if (_instance == null) {
                _instance = new Log(path);
            }

            return _instance;
        }

        private Log(string path) 
        {
            this.path = path;
        }

        public void GuardarLog(string text) 
        {
            File.AppendAllText(this.path, text +  Environment.NewLine);
        }
    }
}
