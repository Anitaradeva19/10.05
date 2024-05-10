using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines=int.Parse(Console.ReadLine());
            var Name = new List<Ime>();
            for(int i=0; i<lines; i++)
            {
                var cmArgs=Console.ReadLine();
                var name= new Ime(cmArgs[0], cmdArds[1], int.Parse(cmdArgs[2]));
                Name.Add(name);
            }
            Ime.Order();
            
        }
    }
}
