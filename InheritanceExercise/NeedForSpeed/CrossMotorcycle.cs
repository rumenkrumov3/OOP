﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class CrossMotorcycle : Motorcycle
    {
        public CrossMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
    }
}
