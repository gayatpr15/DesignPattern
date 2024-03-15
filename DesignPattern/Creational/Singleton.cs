using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational
{
    internal class Singleton
    {
        private Singleton() { }
        public static Singleton Instance { get; } = new Singleton();

        public static Singleton GetInstance() {
            return Singleton.Instance;
        }

        public void DisplayMessage() {
            Console.WriteLine("This is Singleton Design Pattern");
        }
    }
}
