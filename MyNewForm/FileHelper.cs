using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewForm
{
    public class FileHelper
    {
        public void Write(Person newperson)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter(newperson.Filename+".json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, newperson);
                }
            }
        }
        public Person Read(string filename)
        {
            Person person= new Person();
            try
            {
                var context = File.ReadAllText(filename);
                person = JsonConvert.DeserializeObject<Person>(context);
            }
            catch (Exception)
            {

            }
            return person;
        }
    }
}
