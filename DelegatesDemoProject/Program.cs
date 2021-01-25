using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemoProject
{

    /// <summary>
    /// Declare a delegates here
    /// </summary>

    public delegate void MyAddDelegate(int a, int b);

    public delegate int MyDiffDelegate(int a, int b);
    
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            ///Delegate for Instance method
            // Instantiate a delegate

            MyAddDelegate delegate1 = new MyAddDelegate(p.Add);

            // Invoke a delegate 

            delegate1(1, 2);

            //Other way to Invoke

            delegate1.Invoke(1, 3);

            ///Delegate for Static method
            // Instantiate a delegate

            MyDiffDelegate delegate2 = new MyDiffDelegate(Program.Difference);

            int diff = delegate2(4, 3);

            Console.WriteLine(diff);

        }
        
        //instance method to add 
        public void Add(int a , int b)
        {
            Console.WriteLine(a + b);
        }

        //static method for difference
        public static int Difference(int a, int b)
        {
            return a - b;
        }


    }
}
