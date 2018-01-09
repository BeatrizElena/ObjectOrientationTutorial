using System;
// Encapsulation: Analogy: Not caring about what happens inside the factory, just caring about the output.
// (Same idea as separating methods into a separate part of the file or even into another file)
namespace Bulldozer
{
    class Program
    {
        public static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            var result = worker.AddNumbers(2, 3); //AddNumbers here represent "the factory"
            Console.WriteLine(result.ToString ());
        }
    }

    public class FactoryWorker
    {
        public FactoryWorker()
        {
        }

        //AddNumbers method will have the "factory" portion of our code.
        public int AddNumbers (int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        }
    }
}

/*
 * Version 1: Classes and Objects
namespace Bulldozer
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dozer = new BullDozer("Yellow", "Mini");
            // 2 lines below no longer needed bc a constructor (ie a method) was created in the class BullDozer
            // dozer.color = "Yellow";
            // dozer.size = "Mini";
            var dozer2 = new BullDozer("Red", "Large");
            Console.WriteLine("Bulldozer1 is: " + dozer.color);
            Console.WriteLine("Bulldozer2 is: " + dozer2.color);
        }
    }

    public class BullDozer
    {
        // constructor for color and size
        public BullDozer(string _color, string _size)
        {
            this.color = _color;
            this.size = _size;
        }
        public string color { get; set; }
        public string size { get; set; }
    }
}
*/

/*
 Version 2a: Using Inheritance (3 objects: Man, Kart & Alien) AND learning that two separate base classes 
 CANNOT be daisy-chained in C# as in: public class Man : CommonConstructs, Human
namespace Bulldozer
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dozer = new Man();
            var kart = new Kart();
            var alien = new Alien();
        }
    }
    // Constructs inherited by all objects
    public class CommonConstructs
    {
        public CommonConstructs()
        {
        }
        public bool moves { get; set; }
        public string color { get; set; }
    }

    // Constructs inherited by human objects only
    public class Human
    {
        public Human()
        {
        }
        public string name { get; set; }
    }

    // Man object inherits CommonConstructs and Human (initially, Man had its own unique 'name' property 
    //but with the creation of the Woman object, the code for name was refactored into a separate construct.
    public class Man : CommonConstructs, Human
    {
        public Man()
        {
        }
    }

    // Woman object inherits CommonConstructs and Human constructs
    public class Woman : CommonConstructs, Human
    {
        public Woman()
        {
        }
    }

    // Kart object inherits CommonConstructs and has unique 'manufacturer' property
    public class Kart : CommonConstructs
    {
        public Kart()
        {
        }
        public string manufacturer { get; set; }
    }

    // Alien object inherits CommonConstructs and has unique 'planet' property

    public class Alien : CommonConstructs
    {
        public Alien()
        {
        }
        public string planet { get; set; }
    }
}
 */

/*
using System;
//Version 2b: Using Inheritance (3 objects: Man, Kart & Alien) & Creating Separate Constructs
namespace Bulldozer
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dozer = new Man();
            var kart = new Kart();
            var alien = new Alien();
        }
    }
    // Constructs inherited by all objects
    public class CommonConstructs
    {
        public CommonConstructs ()
        {
        }
        public bool moves { get; set; }
        public string color { get; set; }
    }

        // Human is a construct inherited by human objects only, but it itself must be inherited under Commonconstructs
        // to attach both set of properties to the Human objects (in C#).
        public class Human : CommonConstructs
        {
            public Human ()
            {
            }
            public string name { get; set; }
        }

            // Man object inherits CommonConstructs and Human (initially, Man had its own unique 'name' property 
            //but with the creation of the Woman object, the code for name was refactored into a separate construct.
            public class Man : Human
            {
                public Man()
                {
                }
            }

            // Woman object inherits CommonConstructs and Human constructs
            public class Woman : Human
            {
                public Woman()
                {
                }
            }

    // Kart object inherits CommonConstructs and has unique 'manufacturer' property
    public class Kart : CommonConstructs
    {
        public Kart()
        {
        }
        public string manufacturer { get; set; }
    }

    // Alien object inherits CommonConstructs and has unique 'planet' property
    public class Alien : CommonConstructs
    {
        public Alien()
        {
        }
        public string planet { get; set; }
    }
}
*/
/* Polymorphism
using System;
//Polymorphism: 2 methods on the same object that have different inputs but allow you to do the same thing; e.g. count.
namespace Bulldozer
{
    class Program
    {
        public static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            worker.Count(4);
            worker.Count(5);
            worker.Count(4.5f);
        }
    }

    public class FactoryWorker
    {
        public FactoryWorker ()
        {
        }
        public void Count (int number)
        {
            if (Total == null)
                Total = 0;

            Total = Total + Convert.ToSingle(number);
            Console.WriteLine(Total.ToString ());
        }

        public void Count (float number)
        {
            Total = Total + number;
            Console.WriteLine(Total.ToString());
        }

        // adding more data types to the Count method
        public void Count (int num1, float num2, double num3)
        {
            
            // I can add code here to add all 3 data types and then add that to the Total
              
        }

        public float Total { get; set; }
    }
    
}
*/
