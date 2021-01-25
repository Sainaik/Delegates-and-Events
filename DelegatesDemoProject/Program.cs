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

    public delegate void RectangleDelegate(double height, double width);

   
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            ///Delegate for Instance method
            // Instantiate a delegate

            RectangleDelegate recDelegate = p.RectangleArea;

            recDelegate += p.RectanglePerimeter;   // MultiCasting

            recDelegate(10.3, 20.45); // Invokes both methods 
            
        }
        
        //Calculate Area
        public void RectangleArea(double height, double width)
        {
            Console.WriteLine("Area  : " + 3.14 * height * width);
        }

        //Calculate Perimeter
        public  void RectanglePerimeter(double height, double width)
        {
            Console.WriteLine("Perimeter  : " + 2 * height * width);
        }


    }
}
