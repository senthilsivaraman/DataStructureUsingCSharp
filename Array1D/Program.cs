using System;

namespace ArrayDataStructure
{
    public class SingleDimensionArrayMain
    {
        int[] intArray = new int[10];
        
        public SingleDimensionArrayMain(int sizeOfArray)                 // New Array Creation
        {
            Console.WriteLine("\n\nNew Array Creation From Argument");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            int[] newArray1 = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                newArray1[i] = int.MinValue;
            }

            try                                                         // Array Traversal
            {
                for (int i = 0; i < newArray1.Length; i++)
                {
                    Console.WriteLine("newArray1[{0}] - - {1}", i, newArray1[i]);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Array no longer exists", e);
            }
        }

        public void PrintArray(int[] array2)                            // Array Traversal
        {            
            try
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    Console.Write("   ", array2[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Array no longer exists");
            }
        }

        public void ArrayInitialization()
        {
            Console.WriteLine("\n\nInserting duplicate element in array at same place");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            //Differnt methods to initialize
            
            int[] array2 = new int[4] { 23, 32, 2, 0 };
            //int[] array3 = array2;
            //int[] array4 = new int[] { 1, 2, 3, 4, 5, 6 };
            //int[] array5 = { 1, 2, 3, 4, 5 };
            // int[] array6 = new int[2] { 0, 1, 2, 3 };error for missize


            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("Array[{0}] - - {1}", i, array2[i]);
            }
            Console.WriteLine("\nAfter declaring duplicate in the same index  array2[3]");
            array2[3] = 555;
            Console.WriteLine("Array[1] - - {0}", array2[3]);
        }

        public void ArrayInsert(int location, int valueToBeInserted)
        {
            Console.WriteLine("\n\nArray Insert");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            for (int i=0; i<10; i++)
            {
                intArray[i] = int.MinValue;
                intArray[4] = 4;
                Console.WriteLine("intArray[{0}]- -{1}", i, intArray[i]);                
            }
            try
            {
                if (intArray[location] == int.MinValue)
                {
                    intArray[location] = valueToBeInserted;
                    Console.WriteLine("\nNew element in intArray[{0}] is", intArray[location]);
                    Console.WriteLine("\nAfter Inserting {0} in intArray[{1}]\n", valueToBeInserted, location);
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        Console.WriteLine("intArray[{0}]- -{1}",i, intArray[i]);
                    }
                }
                else
                {
                    Console.WriteLine("The Location intArray[{0}] is occupied already", location);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                System.Console.WriteLine(e.Message);
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);

            }

        }

        public void AccessingElement(int cellNumber)
        {
            Console.WriteLine("\n\n Accessing Element in an Array");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            try
            {
                Console.WriteLine("Element at intArray[{0}] is : {1}", cellNumber, intArray[cellNumber]);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
        }


        public void SearchingElement(int value)
        {
            Console.WriteLine("\n\n Searching value in an Array");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            for (int i = 0; i < intArray.Length; i++)
            {
                if(intArray[i] != value)
                {
                    Console.WriteLine("Element not foud in the IntArray");
                }
                else
                {
                    Console.WriteLine("Element - {0} found at intArray[{1}]", value, i);
                }
            }
        }

        public void DeleteElement(int index)
        {
            try
            {
                intArray[index] = int.MinValue;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            SingleDimensionArrayMain obj = new SingleDimensionArrayMain(10);            //Array Creation from argument and initializing min value
            obj.ArrayInitialization();
            obj.ArrayInsert(4, 555);
            obj.AccessingElement(4);
            obj.SearchingElement(4);
            obj.DeleteElement(2);

        }
       

    }
}
