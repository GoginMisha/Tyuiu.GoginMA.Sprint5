using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GoginMA.Sprint5.Task5.V22.Lib
{
    public class DataService : ISprint5Task5V22
    {
        public double LoadFromDataFile(string path)
        {
            double res = 100;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if ((Convert.ToDouble(line) < res) && (Convert.ToDouble(line) % 4 == 0))
                    {
                        res = Convert.ToDouble(line);
                    }
                }
            }
            return res;
        }
    }
}
