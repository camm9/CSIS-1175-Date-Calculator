using System;
using static System.Console;

/*Create  a  Date class  with  integer  data  members  for  year,  month,  and  day.  
 * Also  include  a  string  data  member  for  the  name  of  the  month.  
 * Include a method that returns the month name (as a string) as part of the date. 
 * Separate the day from the year with a comma in that method. 
 Output Example: May 24, 1994*/

namespace DateApp
{
    class DateApp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the month.");
            int month = Convert.ToInt32(ReadLine());
            int monthNum = Convert.ToInt32(month);
            string result = Date.monthName(monthNum);




            WriteLine("Enter the number of the day in the month.");
            int day = Convert.ToInt32(ReadLine());

            WriteLine("Enter the year number.");
            int year = Convert.ToInt32(ReadLine());



            Date userDate = new Date(year, monthNum, day);

            Date.printDate(year, month, day, result);
        }
    }
    class Date
    {
        int year;
        int month;
        int day;

        public int Year
        {
            get; set;
        }

        public int Month
        {
            get; set;
        }

        public int Day
        {
            get; set;
        }
        public static string monthName(int monthNum)
        {
            string monthNumber;
        
            switch (monthNum)
            {
                case 1:
                    monthNumber = "January";
                    break;
                case 2:
                    monthNumber = "February";
                    break;
                case 3:
                    monthNumber = "March";
                    break;
                case 4:
                    monthNumber = "April";
                    break;
                case 5:
                    monthNumber = "May";
                    break;
                case 6:
                    monthNumber = "June";
                    break ;
                case 7:
                    monthNumber = "July";
                    break;
                case 8:
                    monthNumber = "August";
                    break;
                case 9:
                    monthNumber = "September";
                    break;
                case 10:
                    monthNumber = "October";
                    break;
                case 11:
                    monthNumber = "November";
                    break;
                case 12:
                    monthNumber = "December";
                    break;
                default: 
                    monthNumber = "Choose a month number between 1 and 12.";
                    break;
            }
            string result = monthNumber;
            return result;
         
        }

        public Date(int year, int month, int day)
        {
            year = Year;
            month = Month;
            day = Day;
        }

        public static void printDate(int year, int month, int day, string result)
        {
            WriteLine("The date is: " + day+ "/"+ month + "/" + year  +"\nIt is written as: " + result +" "+ day + ", " + year );
        }


    }
}