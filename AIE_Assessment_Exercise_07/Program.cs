/*
 * Appendix 4 - Exercise 1: Greetings
 */

using System;

namespace AIE_Assessment_Exercise_07
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // Create instances of
            // - A Person and Doctor classes.

             Person p1 = new Person("Bob");
             Doctor p2 = new Doctor("Fred");
             Person p3 = new Doctor("Ted");

            

            // Invoke the "SayGreeting" method on the above instances
             p1.SayGreeting(); // hello I'm Bob
             p2.SayGreeting(); // hello I'm Dr. Fred
             p3.SayGreeting(); // hello I'm Dr. Ted
        }

        
    }
    class Person
    {
        public string name ="";
        public Person(string name) 
        {
            this.name = name;
        }
        public virtual void SayGreeting()
        {
            Console.WriteLine("Hello, i'm " + name);
        }
    }

    class Doctor : Person
    {
        public Doctor(string name) : base(name)
        {

        }

        public override void SayGreeting()
        {
            Console.WriteLine("Hello, i'm Dr " + name);
            
        }
    }
}
