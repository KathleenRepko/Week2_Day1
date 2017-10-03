using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] favoriteNumbers = { 61, 22, 3, 44, 105, 36 };

            //string[] studentNames = { "Raz", "Monica", "David", "Brian", "Ali" };

            //Console.WriteLine(favoriteNumbers[0]);
            //Console.WriteLine(studentNames[2]);

            ////Top 10 vacation spots
            ////Print the first and last vacation spots
            //string[] topVacation = { "Paris", "London", "Hawaii", "Key West", "New York City", "Amsterdam", "San Francisco", "Madrid", "Rome", "Athens" };
            //Console.WriteLine("The number one vacation spot is " + topVacation[0] + ". The tenth vacation spot is " + topVacation[9] + ".");

            ////Ages of 3 children you know
            ////Print each child's age
            //int[] childAge = { 12, 19, 21 };
            //Console.WriteLine(childAge[0] + ", " + childAge[1] + ", " + childAge[2]);
            ////or
            //string[] childNameAndAge = { "MaryJo is 12", "Caroline is 19", "Maddie is 21" };
            //Console.WriteLine(childNameAndAge[0] + ", " + childNameAndAge[1] + ", and " + childNameAndAge[2] + ".");

            ////GPAs on a 4.0 scale of 8 students
            //double[] studentsGPAs = { 4.0, 3.5, 2.9, 3.2, 3.9, 1.7, 2.4, 3.3 };
            //Console.WriteLine(studentsGPAs[0] + ", " + studentsGPAs[1] + ", " + studentsGPAs[2] + ", " + studentsGPAs[3] + ", " + studentsGPAs[4] + ", " + studentsGPAs[5] + ", " + studentsGPAs[6] + ", " + studentsGPAs[7]);

            ////First letter of 4 of your peers'names who are sitting near you
            //char[] classmateInitials = { 'B', 'K', 'B', 'D' };
            //Console.WriteLine("The initials of four classmates sitting near me are " + classmateInitials[0] + ", " + classmateInitials[1] + ", " + classmateInitials[2] + ", and " + classmateInitials[3] + ".");

            // Default value for int is 0.
            // Default value for string is " "

            //int[] numbers = new int[4];
            //numbers[0] = 43;
            //numbers[1] = 12;
            //Console.WriteLine("Please enter a number.");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter another number.");
            //numbers[3] = int.Parse(Console.ReadLine());

            //numbers[0] = 30;
            //// You may change the value of the variable.

            //Console.WriteLine(numbers[3]);

            //Declare and initialize a string array with the 7 days of the week as its elements.
            //string[] weekDays = new string[7];
            //weekDays[0] = "Sunday";
            //weekDays[1] = "Monday";
            //weekDays[2] = "Tuesday";
            //weekDays[3] = "Wednesday";
            //weekDays[4] = "Thursday";
            //weekDays[5] = "Friday";
            //weekDays[6] = "Saturday";

            ////Declare and initialize an array of 5 student ages using the “new” keyword.
            //int[] studentAges = new int[5];
            //studentAges[0] = 18;
            //studentAges[1] = 17;
            //studentAges[2] = 19;
            //studentAges[3] = 24;
            //studentAges[4] = 22;

            //Console.WriteLine(weekDays.LongLength);
            ////Returns the number of items in the array.

            ////Declare and initialize an array of characters spelling out your last name.Print the length of the array.
            //char[] lettersInLastName = { 'R', 'E', 'P', 'K', 'O' };
            //or
            //char[] lettersInLastName = new char[5];
            //lettersInLastName[0] = 'R';
            //lettersInLastName[1] = 'E';
            //lettersInLastName[2] = 'P';
            //lettersInLastName[3] = 'K';
            //lettersInLastName[4] = 'O';
            //Console.WriteLine(lettersInLastName.Length);

            ////Declare and initialize a string array. Using the Length property, print the second to last element in the array.
            ////string[] fruits = new string[4];
            ////fruits[0] = "banana";
            ////fruits[1] = "apple";
            ////fruits[2] = "pear";
            ////fruits[3] = "grape";
            ////or
            //string[] fruits = { "banana", "apple", "pear", "grape" };

            //int secondLast = ((fruits.Length) - 2);
            //Console.WriteLine(fruits[secondLast]);
            ////or
            ////Console.WriteLine(fruits[fruits.Length - 2]);

            //Console.WriteLine("This is the last index: " + (fruits.Length - 1));
            //Useful when number of elements in array has changed.

            //For user to determine length of array:
            Console.WriteLine("Please enter the size of your array.");
            int arraySize = int.Parse(Console.ReadLine());
            int[] newArray = new int[arraySize];
            Console.WriteLine("The array is of length " + newArray.Length);
        }
    }
}
