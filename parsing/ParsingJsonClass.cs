using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace parsing
{
    public class ParsingJsonClass
    {
        private const string PATH = "C:\\Parsing\\parsing.json";
        public string _title { get; set; }
        public ParsingJsonClass(string title)
        {
            _title = title;

        }
        public void CreateJson(ParsingJsonClass parsingJsonClass)
        {
            var parsingJsonClasses = new List<ParsingJsonClass>();

            if (File.Exists(PATH))
            {
                using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
                {
                    parsingJsonClasses = JsonSerializer.Deserialize<List<ParsingJsonClass>>(fs);
                }
            }
            parsingJsonClasses.Add(parsingJsonClass);
            Write(parsingJsonClasses);
        }

        private void Write(List<ParsingJsonClass> parsingJsonClass)
        {
            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<ParsingJsonClass>>(fs, parsingJsonClass);
            }
        }

    }
}
