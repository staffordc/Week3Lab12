using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Lab12PersonClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            var human = new Person("Grimblo", "420 Highway");
            var pupil = new Student("Dimbly", "4455 Far","Pyshe",3,2500.50);
            var employee = new Staff("Simbim", "135 Wowst", "Wild 'Cademy", 3.50);
            Console.WriteLine(human);
            Console.WriteLine(pupil);
            Console.WriteLine(employee);
            Console.ReadLine();

        }
    }
}
