using System;

namespace StackDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting Stack Size
            Console.WriteLine("Enter the Stack Size");
            int StackSize = Convert.ToInt32(Console.ReadLine());

            //Stack Instantiation
            StackOperations stackObj = new StackOperations(StackSize);
            int userChoice;

            while (true)
            {
                //Stack Operations
                Console.Clear();
                Console.WriteLine("Enter the choice to Perform Stack Operation in Stack");
                Console.WriteLine("1. PUSH");
                Console.WriteLine("2. POP");
                Console.WriteLine("3. Display the Stack");
                Console.WriteLine("4. Delete the Stack");
                Console.WriteLine("5. Exit");

                userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the value");
                        stackObj.PushinStack(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 2:
                        stackObj.PopinStack();
                        break;
                    case 3:
                        stackObj.Printstack();
                        break;
                    case 4:
                        Console.WriteLine("Stack - Delete");
                        stackObj.Deletestack();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input, Try again...");
                        Environment.Exit(0);
                        break;
                }

            }
            

        }
    }

    class StackOperations
    {
        int[] stackArray;
        int currentAddress;

        //Initializing Stack
        public StackOperations(int stackSize)
        {
            stackArray = new int[stackSize];
            currentAddress = -1;
        }
        

        //Setting Upperlimit
        bool isStackFull()
        {
            if (currentAddress == stackArray.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Setting Downlimit
        bool isStackempty()
        {
            if (currentAddress == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PushinStack(int value)
        {
            if (isStackFull())
            {
                Console.WriteLine("Stack is Full");
            }
            else
            {
                stackArray[++currentAddress] = value;
                Console.WriteLine("Item Pushed Successfully");
            }
        }

        public void PopinStack()
        {
            if (isStackempty())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                currentAddress--;
                Console.WriteLine("Item Popped Successfully");
            }
        }

        public void Printstack()
        {
            if (isStackempty())
            {
                Console.WriteLine("Nothing to print, Stack is empty");
            }
            else
            {
                for (int i = currentAddress; i > stackArray.Length; i--)
                {
                    Console.WriteLine("Elements in the Stack");
                    Console.WriteLine(stackArray[currentAddress]);
                }
            }
        }

        public void Deletestack()
        {
            if (isStackempty())
            {
                Console.WriteLine("Nothing to delete, Stack is already empty");
            }
            else
            {
                currentAddress = -1;
                Console.WriteLine("Stack Deleted successfully");
            }
        }
    }
}
