using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        private double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Length cannot be zero or negative.");
                }
                else
                {
                    this.length = value;
                }               
            }
        }

        private double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Width cannot be zero or negative.");
                }
                else
                {
                    this.width = value;
                }                
            }
        }

        private double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Height cannot be zero or negative.");
                }
                else
                {
                    this.height = value;
                }               
            }
        }

        public void SurfaceArea()
        {
            double surface = 2 * ((this.Length * this.Width) + (this.Width * this.Height) + (this.Height * this.Length));
            Console.WriteLine($"Surface Area - {surface:F2}");
        }

        public void LateralSurface()
        {
            double surface = 2 * this.Height * (this.Width + this.Length);
            Console.WriteLine($"Lateral Surface Area - {surface:F2}");
        }

        public void Volume()
        {
            double surface = this.Length * this.Width * this.Height;
            Console.WriteLine($"Volume - {surface:F2}");
        }
    }
}
