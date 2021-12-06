using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            string target;
            Console.WriteLine("Введите что хотите произвести: ");
            target = Console.ReadLine();



            Handler angle = new Angle();
            Handler armature = new Armature();
            Handler bar = new Bar();
            Handler pipe = new Pipe();
            Handler square = new Square();

            angle.Successor = armature;
            armature.Successor = bar;
            bar.Successor = pipe;
            pipe.Successor = square;
            angle.HandleRequest(target);
        }
    }
}
