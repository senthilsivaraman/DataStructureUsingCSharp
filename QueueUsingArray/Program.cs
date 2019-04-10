using System;

namespace QueueDataStructures
{
    public class QueueOperations
    {
        int[] queueArray;
        int startAddress;
        int finalAddress;

        //Initializing Stack
        public QueueOperations(int queueSize)
        {
            queueArray = new int[queueSize];
            startAddress = 0;
            finalAddress = -1;
        }


        //Setting Upperlimit
        bool isQueueFull()
        {
            if (finalAddress == queueArray.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Setting Downlimit
        bool isQueueempty()
        {
            if (finalAddress == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Enqueue(int value)
        {
            
            if (isQueueFull())
            {
                Console.WriteLine("Queue is Full - Overflow");
            }
            else
            {
                queueArray[++finalAddress] = value;
                Console.WriteLine("Item-{0} Enqueued Successfully to the Queue address[{1}]", value, finalAddress);
            }
        }

        public void Dequeue()
        {
            if (isQueueempty())
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                //Console.WriteLine(finalAddress);
                Console.WriteLine("Item - {0} at position [{1}] Dequeued Successfully", queueArray[startAddress], startAddress);
                for(int i=startAddress; i<queueArray.Length-1; i++)
                {
                    queueArray[i] = queueArray[i+1];
                    
                }
                finalAddress--;
            }
        }

        public void PrintQueue()
        {
            if (isQueueempty())
            {
                Console.WriteLine("Nothing to print, Queue is empty");
            }
            else
            {
                for (int i = startAddress; i <= finalAddress; i++)
                {
                    Console.Write("Elements in the Queue position [{0}] -", i);
                    Console.WriteLine(queueArray[i]);
                }
            }
        }

        public void DeleteQueue()
        {
            if (isQueueempty())
            {
                Console.WriteLine("Nothing to delete, Queue is already empty");
            }
            else
            {
                finalAddress = -1;
                Console.WriteLine("Queue Deleted successfully");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Getting Queue Size
            Console.WriteLine("Enter the Queue Size");
            int queueSize = Convert.ToInt32(Console.ReadLine());

            //Stack Instantiation
            QueueOperations stackObj = new QueueOperations(queueSize);
            int userChoice;

            while (true)
            {
                //Stack Operations

                Console.WriteLine("\n\nEnter the choice to Perform Queue Operation in Stack");
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Display the Queue");
                Console.WriteLine("4. Delete the Queue");
                Console.WriteLine("5. Exit");

                userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the value");
                        stackObj.Enqueue(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 2:
                        stackObj.Dequeue();
                        break;
                    case 3:
                        stackObj.PrintQueue();
                        break;
                    case 4:
                        stackObj.DeleteQueue();
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
}
