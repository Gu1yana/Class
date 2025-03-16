using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class
{
    internal class Student
    {
        //field-ler
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool IsGraduated;

        //constructor
        public Student(string name, string surname, byte point, string group, bool isgraduated)
        {
            Name = name;
            Surname = surname;
            Point = point;
            Group = group;
            IsGraduated = isgraduated;
        }
         
        
        //metodlar
        public void GetInfo()
        {
            Console.WriteLine($"Ad:{Name}");
            Console.WriteLine($"Soyad:{Surname}");
            Console.WriteLine($"Bal:{Point}");
            Console.WriteLine($"Qrup:{Group}");
            Console.WriteLine($"Graduated: {(IsGraduated ? "Yes" : "No")}");
        }
        public void ChechGraduation()
        {
            if (IsGraduated)
            {
                Console.WriteLine("telebe mezun olub");
            }
            else
            {
                Console.WriteLine("mezun deyil");
            }
        }
        public void GetDiplomDegree()
        {
            if (Point>90)
            {
                Console.WriteLine("Yuksek sheref diplomu ile teltif olunub");
            }
            if(Point<90 && Point>80)
            {
                Console.WriteLine("Sheref diplomu ile teltif olunub");
            }
            if (Point>65 && Point<80)
            {
                Console.WriteLine("Adi diplom");
            }
            if(Point<65)
            {
                Console.WriteLine("Diplomu yoxdur");
            }
        }

    }
}
