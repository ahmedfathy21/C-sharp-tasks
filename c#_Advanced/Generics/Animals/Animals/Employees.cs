using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals
{
    class Animals
    {
        private string[] namelist = new string[3];
        public string this [int index]
        {
            get { return namelist[index]; }
            set { namelist[index] = value; }
        }
        void moving()
        {
            Console.WriteLine("Moving Animals");
        }
    }

    class Eagle : Animals

    {
        void flying()
        {
            Console.WriteLine("Flying Animals");
        }


    }

    class Falcon : Animals
    {
        void Falcon_Flying()
        {
            Console.WriteLine("Flying Falcon");
        }
    }
}