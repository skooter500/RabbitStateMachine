using System;
using System.Threading;

namespace StateMachineDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Rabbit bunny = new Rabbit();
            
            while (bunny.age < 1000)
            {
                bunny.Update();
                Thread.Sleep(500);
            }
        }
    }
}
