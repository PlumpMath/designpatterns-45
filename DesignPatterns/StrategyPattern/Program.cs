using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace StrategyPattern
{
    public interface FlyBehavior
    {
        void PerformFly();
    }
    public class FlyWithWings : FlyBehavior
    {
        public void PerformFly()
        {
            WriteLine("Fly with wings!");
        }

    }
    public interface QuackBehavior
    {
        void PerformQuack();
    }
    public class Quack : QuackBehavior
    {
        public void PerformQuack()
        {
            Console.WriteLine("Quack!");
        }
    }
    public class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;
        public void PerformQuack()
        {
            quackBehavior.PerformQuack();
        }
        public void PerformFly()
        {
            flyBehavior.PerformFly();
        }
        public void Display()
        {
            WriteLine("I'm duck!");
        }
    }
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        public new void Display()
        {
            WriteLine("I'm Mallard duck!");
        }
    }
    class Program
    {
        //Design principle
        //Identify the aspects of your
        //application that vary and separate
        //them from what stays the same.
        
        //Design principle
        //Program to an interface (abstract class/interface), not an
        //implementation.
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.Display();
        }
    }
}
