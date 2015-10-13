using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EFTest
{
    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string OtherData { get; set; }
        public List<int> BlaBlaList { get; set; }

        public byte[] Serialize()
        {
            string json = JsonConvert.SerializeObject(this);
            return Encoding.ASCII.GetBytes(json);
        }

        public static string Deserialize(byte[] objectBytes)
        {
            return Encoding.ASCII.GetString(objectBytes);
        }
    }

    public class MyDBEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte[] SerializedData { get; set; }
    }
}
