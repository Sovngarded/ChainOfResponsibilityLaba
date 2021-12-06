using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Armature : Handler
    {
        public override void HandleRequest(string target)
        {
            if (target == "Арматура")
            {
                Console.WriteLine(target + " производится ");
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(target);
            }
        }



    }
}
