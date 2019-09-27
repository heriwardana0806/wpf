using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaWpf.API
{
    public class Api
    {
        private string Key { get; set; }
        private string Region { get; set; }

        public Api(string region)
        {
            Region = region;
            Key = GetKey("Api.text");
        }

        public string GetKey(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }
    }
}
