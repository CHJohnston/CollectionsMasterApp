using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] intArray = new int[50];                     

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(intArray);    // Calls the Method Populater 

            Console.WriteLine("Collections Master Console");
            Console.WriteLine();
            Console.WriteLine("We created an Integer Array (intArray) with 50 Elements containing integers in the range 0-50.");

            //Print the first number of the array
            Console.WriteLine($"The first number in intArray at index 0 is {intArray[0]}");

            //Print the last number of the array    
            Console.WriteLine($"The last number in intArray at index {intArray.Length-1} is {intArray[intArray.Length-1]}");
            Console.WriteLine();

            Console.WriteLine("Here is a list of All Numbers in intArray in the Original Order");
            //Use this method to print out your numbers from arrays or lists
            //NumberPrinter(array or list); 
            NumberPrinter(intArray);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */            
            
            Console.WriteLine("We have Reversed the Contents of the intArray using the Array.Reverse Method");
            Array.Reverse(intArray);
            NumberPrinter(intArray);
            Console.WriteLine("-------------------");

            //Put the intArray back in the original order
            Console.WriteLine("We have Reversed the Contents of the intArray again so it is back in the Original Order");
            Array.Reverse(intArray);
            NumberPrinter(intArray);
            Console.WriteLine("-------------------");

            //Call our Custom Reverse Method to Reverse and Return a Reversed Array 
            Console.WriteLine("We have created a Custom Array Reverse Method that creates a copy of intArray in the reversed order called myReverseArray");
            int[] myReverseArray = CustomReverseArray(intArray);
            //Print The Reversed Array             
            Console.WriteLine("Here is a list of All Numbers in myReverseArray");
            NumberPrinter(myReverseArray);
            Console.WriteLine();

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Here is our intArray with Multiples of three set to a 0: ");
            ThreeKiller(intArray);
            NumberPrinter(intArray);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Here is our intArray Sorted in Ascending Order ");
            Array.Sort(intArray);
            NumberPrinter(intArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var intList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine($"We created a new Integer List named intList with an initial Capacity of {intList.Capacity}.");

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this 
            Populater(intList);
            Console.WriteLine($"We populated intList with 50 Random Integers between 0 and 50.");
            NumberPrinter(intList);

            //Print the new capacity
            Console.WriteLine($"Our List now has the Capacity of {intList.Capacity}.");
            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.Write("What number will you search for in the number list?  ");
            //Ask the user to input an Integer and then Check to see if valid
            // Number Converter ensures the user enters a valid integer
            int searchNumber = NumberConverter(Console.ReadLine());
            // NumberChecker checks to see if the valid integer is in the list and prints a message 
            NumberChecker(intList, searchNumber);                      
            Console.WriteLine("-------------------");

            Console.WriteLine("Here are All the Numbers in intList ");
            //Print all numbers in the list
            NumberPrinter(intList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results

            //NOTE - There is a bug in the the OddKiller Method -- Not ALL Even Numbers are Removed

            Console.WriteLine("Odds Only!!");
            OddKiller(intList);
            NumberPrinter(intList);

            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");
            intList.Sort();
            NumberPrinter(intList);

            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var arrayFromList = intList.ToArray();
            Console.WriteLine("We converted our List to an Array");
            NumberPrinter(arrayFromList);

            //Clear the list
            intList.Clear();
            Console.WriteLine("We Cleared the List using intList.Clear() ");

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {//This Method changes any integer passed that is divisible by three to zero
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 3 == 0)
                        numbers[i] = 0;
                }                  
            }            
        }

        private static void OddKiller(List<int> numberList)
        //This method removes the odd numbers from the list
        //NOTE - There is a bug in the the OddKiller Method -- Not ALL Even Numbers are Removed
        {
            for (int i=0; i< numberList.Count; i++)
            {
               if (numberList[i] % 2 == 0)
                {
                    Console.WriteLine($"Removed {numberList[i]} ");
                    numberList.Remove(numberList[i]);                   
                }            
            }            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        //This method determines if the searchNumber is in the list
        { 
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("\n Number Found! \n");
            }
            else
            {
                Console.WriteLine("404 NOT FOUND");
            }            
        }

        private static void Populater(List<int> numberList)
        //This method populates an Integer List with Random numbers
        {
            Random rng = new Random();
            for (int i = 1; i <= 50; i++)
            {
                int rgnInt = rng.Next(50);
                numberList.Add(rgnInt);
            }
        }

        private static void Populater(int[] numbers)
        //This method populates an Integer array with Random numbers
        {
            Random rng = new Random();
            for (int i= 0; i < numbers.Length; i++)
            {
                int ranInt = rng.Next(50);
                numbers[i] = ranInt;
            }        
        }        
       
        private static int[] CustomReverseArray(int[] array)
        //This method creates a temp array that is the reverse of the array passed in the arguements and returns it 
            {
            int[] tempintArray = new int[array.Length];
            int i = 0;
            for (int tempindex = (tempintArray.Length - 1); tempindex >= 0; tempindex--)
            {
                tempintArray[tempindex] = array[i];
                Console.WriteLine($" Original Array[{i}] = {array[i]}   Reversed Array[{tempindex}] = {tempintArray[tempindex]} ");
                i++;
            }            
            return tempintArray;
        }

       public static int NumberConverter(string str)
        // This Method Returns a Valid Integer
        {
            int result;
            // The user will be asked to renter a value until a vaild integer is input
            while (int.TryParse(str, out result) == false)
            {
                Console.WriteLine($"{str} is not an Integer");
                Console.Write("Try Again ");
                str = Console.ReadLine();
            }
            return result;
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
