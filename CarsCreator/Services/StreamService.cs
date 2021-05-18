using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CarsCreator.Models;

namespace CarsCreator.Services
{
    public class StreamService
    {
        String SaveModelPath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Saves.txt";
        public string ReadModels()
        {
            using (var file = new StreamReader(SaveModelPath))
            {
                return file.ReadToEnd();
            }
        }

        public void WriteModel(string s)
        {
            using (var file = new StreamWriter(this.SaveModelPath, true))
            {
                file.WriteLine(s);
            }
        }

        public CarSet GetSavedCarByIndex(int i)
        {
            CarSet cs = new CarSet();
            string actual = ReadModels();
            string[] mas = actual.Split('\n')[i].Replace("\r","").Split(';');
            /*String model = this.carset.model + ";" + this.carset.engineValue + ";" + carset.diskIndex + ";" + carset.carter + ";" +
                carset.signal + ";" + carset.sab + ";" + carset.sit + ";" +
                carset.sonar + ";" + carset.tv + ";" + carset.xeon;*/
            cs.model = mas[0];
            cs.engineValue = Int32.Parse(mas[1]);
            cs.diskIndex = Int32.Parse(mas[2]);
            cs.carter = bool.Parse(mas[3]);
            cs.signal = bool.Parse(mas[4]);
            cs.sab = bool.Parse(mas[5]);
            cs.sit = bool.Parse(mas[6]);
            cs.sonar = bool.Parse(mas[7]);
            cs.tv = bool.Parse(mas[8]);
            cs.xeon = bool.Parse(mas[9]);
            return cs;
        }
    }
}
