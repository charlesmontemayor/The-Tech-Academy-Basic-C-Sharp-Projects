using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            //string
            {
                Console.WriteLine("Select an index for string array.");
                int stringInput = Convert.ToInt32(Console.ReadLine());
                string[] stringArray = { "I", "love", "studying", "C#", "!" };
                bool isString = stringInput <= 4;
                do
                {
                    switch (stringInput)
                    {
                        case 0:
                            Console.WriteLine(stringArray[stringInput]);
                            isString = true;
                            break;
                        case 1:
                            Console.WriteLine(stringArray[stringInput]);
                            isString = true;
                            break;
                        case 2:
                            Console.WriteLine(stringArray[stringInput]);
                            isString = true;
                            break;
                        case 3:
                            Console.WriteLine(stringArray[stringInput]);
                            isString = true;
                            break;
                        case 4:
                            Console.WriteLine(stringArray[stringInput]);
                            isString = true;
                            break;
                        default:
                            Console.WriteLine("Error.");
                            Console.WriteLine("Please select an string index between 0 - 4.");
                            stringInput = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                while (!isString);
            }

            //integer
            {
                Console.WriteLine("Select an index for integer array.");
                int intInput = Convert.ToInt32(Console.ReadLine());
                int[] intArray = {10, 2000, 373, 4500, 1355};
                bool isInt = intInput < 5;
                do
                {
                    switch (intInput)
                    {
                        case 0:
                            Console.WriteLine(intArray[intInput]);
                            isInt = true;
                            break;
                        case 1:
                            Console.WriteLine(intArray[intInput]);
                            isInt = true;
                            break;
                        case 2:
                            Console.WriteLine(intArray[intInput]);
                            isInt = true;
                            break;
                        case 3:
                            Console.WriteLine(intArray[intInput]);
                            isInt = true;
                            break;
                        case 4:
                            Console.WriteLine(intArray[intInput]);
                            isInt = true;
                            break;
                        default:
                            Console.WriteLine("Error.");
                            Console.WriteLine("Please select an integer index between 0 - 4.");
                            intInput = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                while (!isInt);
            }

            //lists
            {
                Console.WriteLine("Select an index for list array.");
                int listInput = Convert.ToInt32(Console.ReadLine());
                List<string> stringList = new List<string>();
                stringList.Add("Hello");
                stringList.Add("Welcome");
                stringList.Add("to");
                stringList.Add("the");
                stringList.Add("World");
                stringList.Add("of");
                stringList.Add("C#");

                bool isList = listInput <= 6;
                do
                {
                    switch (listInput)
                    {
                        case 0:
                            Console.WriteLine(stringList[listInput]);
                            isList = true;
                            break;
                        case 1:
                            Console.WriteLine(stringList[listInput]);
                            isList = true;
                            break;
                        case 2:
                            Console.WriteLine(stringList[listInput]);
                            isList = true;
                            break;
                        case 3:
                            Console.WriteLine(stringList[listInput]);
                            isList = true;
                            break;
                        case 4:
                            Console.WriteLine(stringList[listInput]);
                            isList = true;
                            break;
                        case 5:
                            Console.WriteLine(stringList[listInput]);
                            isList = true;
                            break;
                        case 6:
                            Console.WriteLine(stringList[listInput]);
                            isList = true;
                            break;
                        default:
                            Console.WriteLine("Error.");
                            Console.WriteLine("Please select an list index between 0 - 6.");
                            listInput = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                while (!isList);
            }
            Console.Read();
        }
    }
}