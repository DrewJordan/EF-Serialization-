using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTest.Entities;
using Newtonsoft.Json;

namespace EFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EFContext())
            {
                MyDBEntity x = db.Entities.First();
                string json = MyEntity.Deserialize(x.SerializedData);
                Console.WriteLine(json);
                MyEntity mine = JsonConvert.DeserializeObject<MyEntity>(json);
            }
        }
    }
}
