﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample.Models
{
    class VehicleModel { }

    public class Car
    {
        private string make, model, img;
        private int year;


        public string Make
        {
            get { return make; }
            set { make = value; }

        }

        public string Model
        {
            get { return model; }
            set { model = value; }

        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Img
        {
            get { return img; }

            set { img = value; }
        }
    }


}
