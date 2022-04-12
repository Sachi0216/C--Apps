using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_DaysoftheWeek_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an enum for the days of the week

            // Prompt the user to enter the current day of the week.

            // Assign the value to a variable of that enum data type you just created.

            //Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.
            // Try/Catch 
            try
            {
                TheDaysOfTheWeek theDays = new TheDaysOfTheWeek();
                Console.WriteLine("Please select the current day of the week?");

                string daySelected = Console.ReadLine();

                var TheDay = System.Enum.Parse(typeof(TheDaysOfTheWeek), daySelected);

                TheDaysOfTheWeek parsedEnumValue = (TheDaysOfTheWeek)System.Enum.Parse(typeof(TheDaysOfTheWeek), daySelected);

                //Console.WriteLine(System.Enum.Parse(typeof(Enum_DaysoftheWeek_.Days), daySelected));

                //Console.WriteLine("Today is : ", (TheDaysOfTheWeek)System.Enum.Parse(typeof(TheDaysOfTheWeek), daySelected));
                Console.WriteLine("Today is {0}. ", (TheDaysOfTheWeek)System.Enum.Parse(typeof(TheDaysOfTheWeek), daySelected));

                //Console.WriteLine(System.Enum.GetName(typeof(Enum_DaysoftheWeek_.Days), theDays));

            }
            catch (FormatException e)
            {
                Console.WriteLine("Unable to convert, Please enter an actual day of the week. ");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }


        }

    }
}
