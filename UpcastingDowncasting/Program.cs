using System;

namespace UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();
            
            Shark shark = new Shark();
            //Console.WriteLine(shark);


            //upcasting ,boxing,implicit
            //Animal shark1 = shark;
            //Console.WriteLine(shark.GetType());


            //downcastin,unboxing,explicit

            Animal animal = new Shark();
            Shark shark2 =(Shark)animal;


            object[] arr = { 1, true, animal, shark2, eagle };
            

            foreach (var item in arr)
            {
                //1
                //if (item is Shark)
                //{
                //    ((Shark)item).Swim();
                //    
                //}
                //else
                //{
                //    Console.WriteLine("shark deyil");
                //}

                //2
                //if (item is Shark s )
                //{
                //    s.Swim();
                //}
                //else
                //{
                //    Console.WriteLine("shark deyil");
                //}
                Shark shark3 = item as Shark;
                if (shark3 != null)
                {
                    shark3.Swim();
                }

            }

        }
    }

   abstract class Animal
    {
        public abstract void Eat();
    }
    abstract class Fish:Animal
    {
      
        public virtual void Swim()
        {

        }
    }

    class Shark : Fish
    {
        public int TeethCount { get; set; }
        public string Name { get; set; }
        public override void Eat()
        {
            Console.WriteLine("eat as shark");
        }

        public override void Swim()
        {
            Console.WriteLine("swim as shark");
        }




    }

    abstract class Bird : Animal
    {
      public virtual void Fly()
        {

        }
    }
    class Eagle : Bird
    {
        public string Color { get; set; }
        public override void Eat()
        {
            Console.WriteLine("eat as eagle");
        }
    }


}
