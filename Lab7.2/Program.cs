using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону куба:");
            double cubeA = Convert.ToDouble(Console.ReadLine());
            double cubeVolume = 0;
            double cubeSurfaceArea = 0;
            GetVolumeAndSurfaceAreaOfCube(cubeA, ref cubeVolume, ref cubeSurfaceArea);
            Console.WriteLine("Объем куба равен: {0}, площадь куба равна: {1}", cubeVolume, cubeSurfaceArea);
            Console.ReadKey();
        }
        static void GetVolumeAndSurfaceAreaOfCube(double ribLength, ref double volume, ref double surfaceArea)
        {
            volume = ribLength * ribLength * ribLength;
            surfaceArea = ribLength * ribLength * 6;
        }
    }
}
