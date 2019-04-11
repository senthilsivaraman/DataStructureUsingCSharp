using System;

namespace CircularQueue
{
    public class QueueOperations
    {
        int[] queueArray;
        int front;
        int rear;

        //Initializing Stack
        public QueueOperations(int queueSize)
        {
            queueArray = new int[queueSize];
            front = -1;
            rear = -1;
        }


        //Setting Upperlimit
        bool isQueueFull()
        {
            if ((rear == queueArray.Length - 1 && front == 0) || (rear == front - 1)) 
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
            if (front == -1)
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
                if(rear==-1)
                {
                    front = 0;
                    rear = 0;
                }
                else if(rear==queueArray.Length-1)
                {
                    rear = 0;
                }
                else
                {
                    rear++;
                }
                queueArray[rear] = value;
                Console.WriteLine("Item-{0} Enqueued Successfully to the Queue address[{1}]", value, rear);
            }
        }

        public void Dequeue()
        {
            int a;
            if (isQueueempty())
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                a = queueArray[front];
                if(front == rear)
                {
                    front = -1;
                    rear = -1;
                }
                else if (front==queueArray.Length-1)
                {
                    front = 0;
                }
                else
                {
                    front++;
                }
                Console.WriteLine("Item - {0} at position [{1}] Dequeued Successfully", a, front);
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
                if(front>rear)
                {
                    for(int i = front; i < queueArray.Length; i++)
                    {
                        Console.Write("Elements in the Queue position [{0}] -", i);
                        Console.WriteLine(queueArray[i]);
                    }
                    for(int j = 0; j <= rear; j++)
                    {
                        Console.Write("Elements in the Queue position [{0}] -", j);
                        Console.WriteLine(queueArray[j]);
                    }
                }
                else
                {
                    for (int i = front; i <= rear; i++)
                    {
                        Console.Write("Elements in the Queue position [{0}] -", i);
                        Console.WriteLine(queueArray[i]);
                    }
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
                front = -1;
                rear = -1;
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
