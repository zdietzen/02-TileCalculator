using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TileCalculator
{
    class Program
    {
        static void Main(string[] args)
            /* 
            
        Bugs- *Need to add try/catch statements
              *Need to round total cost to neareast hundreath

            */
        {
            Console.WriteLine("Welcome to Tilr job estimate!");
          
            string strWidth; // These three strings hold value for me
            string strLength;
            string strCPSF;
           
            Console.WriteLine("Please enter the WIDTH of the room.");
            strWidth = Console.ReadLine(); // Has the user input information and stores it to the string 
            
        
            Console.WriteLine("Please enter the LENGTH of the room.");
            strLength = Console.ReadLine();

            Console.WriteLine("Please enter the cost per square foot of material.");
            Console.Write("$");
            strCPSF = Console.ReadLine();

         

            double dblWidth; // These doubles store the converted numbers
            double dblLength;
            double dblCPSF;

            dblWidth = Convert.ToDouble(strWidth); //This converts the user input values into a usable number
            dblLength = Convert.ToDouble(strLength);
            dblCPSF = Convert.ToDouble(strCPSF);

            double dblTotalCost = dblCPSF * dblWidth * dblLength; // This is the multiplication to get your total cost

            Console.WriteLine(("Your total cost is...${0}"), dblTotalCost);
            Console.WriteLine("Thank you for using Tilr!");
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
