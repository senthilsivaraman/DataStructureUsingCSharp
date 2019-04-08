using System;

namespace TwoDimensionalArrai
{
    class Array2d
    {
        int[,] ourArray = null;


        public Array2d(int noofrow, int noofcol)
        {
            this.ourArray = new int[noofrow, noofcol];
            for (int i = 0; i < noofrow; i++)
            {
                for (int j = 0; j < noofcol; j++)
                {
                    ourArray[i, j] = int.MinValue;
                }
            }
        }

        public void TraverseArray()
        {
            Console.WriteLine("\nPriting Arrays");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            try
            {
                for (int i = 0; i < ourArray.GetLength(0); i++)
                {
                    for (int j = 0; j < ourArray.GetLength(1); j++)
                    {
                        Console.Write(ourArray[i, j] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Array is not present");
            }
        }

        public void AccessArray(int row, int col)
        {
            Console.WriteLine("\n\n Accessing Element in an Array");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            try
            {
                Console.WriteLine("Element at intArray[{0}, {1}] is : {2}", row, col, ourArray[row, col]);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
        }

        public void InsertInArray(int row, int col, int value)
        {
            Console.WriteLine("\n\n Inserting an Element into the Array");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            try
            {
                if (ourArray[row, col] == int.MinValue)
                {
                    ourArray[row, col] = value;
                    Console.WriteLine("Value-{0} inserted successfully at ourArray[{1},{2}]", value, row, col);
                }
                else
                {
                    Console.WriteLine("Location already occupied");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                throw new IndexOutOfRangeException("Invalid index");
            }
        }

        public void DeleteInArray(int row, int col)
        {
            Console.WriteLine("\n\n Deleting a Value in the Specific Index");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            try
            {
                if(ourArray[row, col] != int.MinValue)
                {
                    ourArray[row, col] = int.MinValue;
                    Console.WriteLine("Value at ourArray[{0},{1} deleted successfully]", row, col);
                }
                else
                {
                    Console.WriteLine("Position already empty");
                }
                
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
        }

        public void SearchInArray(int value)
        {
            Console.WriteLine("\n\n Searching a value in an array");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            for (int i = 0; i < ourArray.GetLength(0); i++)
            {
                for (int j = 0; j < ourArray.GetLength(1); j++)
                {
                    if (ourArray[i, j] != value)
                    {
                        Console.WriteLine("The Value-{0} not found in the array at ourArray[{1}, {2}]", value, i, j);
                    }

                    else
                    {
                        Console.WriteLine("The Value-{0} found in the array at ourArray[{1}, {2}]", value, i, j);
                    }
                }
            }
        }

    }    
    class Program
    {
        static void Main(string[] args)
        {
            Array2d obj = new Array2d(3, 3);
            obj.TraverseArray();
            obj.AccessArray(2, 2);
            obj.SearchInArray(22);
            obj.DeleteInArray(2, 2);
            obj.InsertInArray(1,1,22);
            obj.TraverseArray();
            obj.SearchInArray(22);
        }
    }
}
