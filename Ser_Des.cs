using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace WpfApp2._4
{
    internal class Ser_Des
    {
        public static void Serialize<T>(T for_ser, string file_name, int All_Dob)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            desktop = desktop + "\\Практика_2.4_по_шарпу\\";

            string json = JsonConvert.SerializeObject(for_ser);

            if (All_Dob == 1)
            {
                File.WriteAllText(desktop + file_name, json);
            }
            else if (All_Dob == 2) 
            {
                File.AppendAllText(desktop + file_name, json);
            }
        }

        public static T Deserialize<T>(string file_name)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            desktop = desktop + "\\Практика_2.4_по_шарпу\\";

            string json = File.ReadAllText(desktop + "\\" + file_name);
            T des = JsonConvert.DeserializeObject<T>(json);
            return des;
        }
    }
}
