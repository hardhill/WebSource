using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace WebSource
{
    class Genstr
    {

        List<string> txt;
        public Genstr(string fname)
        {
            string curDirectory = Directory.GetCurrentDirectory();
            using (StreamReader sr = new StreamReader($"{curDirectory}\\View\\text.txt", Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    txt = new List<string>();
                    string[] words = line.Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
                    foreach(var w in words)
                    {
                        txt.Add(w);
                    }
                    
                }    
            }
            using (StreamWriter sw = new StreamWriter($"{curDirectory}\\View\\newtext.txt"))
            {
                foreach (var line in txt) {
                    sw.WriteLine(line);
                }
            } 
        }


    }
}
