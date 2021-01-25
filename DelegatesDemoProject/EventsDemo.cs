using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemoProject
{
    public delegate void TransformerDelegate(int number);
    
    public class EventsDemo
    {
     
        public static void Square(int number)
        {
            int square = number * number;
            Console.WriteLine(square);
        }

        public static void Cube(int number)
        {
            int cube = number * number * number;
            Console.WriteLine(cube);
        }

    }

    public class NotificationClass
    {

        public event TransformerDelegate publisher;

        public void Notify(int x)
        {
            if (publisher != null)
            {
                publisher(x);
            }

        }

    }

    public class Subscriber1
    {
        public static void EventHandler1(int x)
        {
            Console.WriteLine("Event handled by Subscriber1");
        }
    }

    public class Subscriber2
    {
        public static void EventHandler2(int x)
        {
            Console.WriteLine("Event handled by Subscriber2");
        }
    }



}
