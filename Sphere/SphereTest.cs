using System;
using System.Collections.Generic;
using System.Text;

namespace Sphere
{
    class SphereTest
    {
        public static void Main(String[] args)
        {
            Sphere defaultSphere = new Sphere();
            Console.WriteLine(defaultSphere.ToString());
            Console.WriteLine(defaultSphere.GetDiameter());
            Console.WriteLine(defaultSphere.GetSurfaceArea());
            Sphere newSphere = new Sphere(15);
            Console.WriteLine(newSphere.ToString());
            Console.WriteLine(newSphere.GetDiameter());
            Console.WriteLine(newSphere.GetSurfaceArea());
        }
    }
}
