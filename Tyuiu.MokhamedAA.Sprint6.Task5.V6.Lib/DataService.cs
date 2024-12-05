﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MokhamedAA.Sprint6.Task5.V6.Lib
{
    public class DataService : ISprint6Task5V6
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Math.Round(Convert.ToDouble(line), 3);
                    index++;
                }
            }

            numsArray = numsArray.Where(val => val % 3 == 0).ToArray();
            return numsArray;
        }
    }
}
