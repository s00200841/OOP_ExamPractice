﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Phone Class for information of phones to be stored
namespace OOP_ExamPractice
{
    public class Phone
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public Phone(string name, decimal price, string os, string osImage = "", string phoneImage = "")
        {
            Name = name;
            Price = price;
            OperatingSystem = os;
            OS_Image = osImage;
            Phone_Image = phoneImage;
        }
        public override string ToString()
        {
            return Name;
        }

        public void IncreasePrice(double increase)
        {
            Price *= (decimal)(1 + increase);
        }
    }
}
