using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class StartUp
    {
        static void Main()
        {
            double Lenght = double.Parse(Console.ReadLine());
            double Width = double.Parse(Console.ReadLine());
            double Height = double.Parse(Console.ReadLine());

            Box box = new Box(Lenght, Width, Height);
            if(Lenght <= 0 || Width <= 0 || Height <= 0)
            {                
            }
            else
            {
                box.SurfaceArea();
                box.LateralSurface();
                box.Volume();
            }        
            
        }       
    }
}
