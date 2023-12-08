using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3
{
    public class Person
    {
        public string Name { get; private set; } 

        public Hair HairStyle { get; private set; }
        
        public Gender TheGender { get; private set; }

        public DateTime Birthday { get; private set; }

        public string EyesColor { get; private set; }


        public Person (string name, Hair hair, Gender gender, DateTime birthday,string eyescolor)
        {
            Name = name;
            HairStyle = hair;
            TheGender = gender; 
            Birthday = birthday;
            EyesColor = eyescolor;
           
        }
        public override string ToString()
        {
            return $"Name: {Name}" +
                $"\nHair: {HairStyle.HairColor} {HairStyle.HairLength}" +
                $"\nSex: {TheGender}" +
                $"\nBirthday: {Birthday:yyyy/MM/dd}" +
                $"\nEyesColor: {EyesColor}";
             


        }
      
    }
}
