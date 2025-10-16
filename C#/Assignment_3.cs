using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment_3
{
    class program
    {
        static void Main(string[] args)
        {
            myclass obj1 = new myclass { value = 10 };
            myclass obj2 = obj1;
            obj1.value = 20;
            Console.WriteLine($"obj2.value : " +obj2.value);
            Console.WriteLine($"obj1.value : {obj1.value}");
            obj2.value = 30;
            Console.WriteLine($"obj1.value : {obj1.value}");
            Console.WriteLine($"obj2.value : {obj2.value}");
    
    }   
    }

}
class myclass {
    public int value { get; set; }
}