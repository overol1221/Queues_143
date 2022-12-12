using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_143
{

    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Program()
        {
            /*intializing the values of the variables REAR and FRONT to -1 to indicate that * the queue is intializing empty.*/
            FRONT =-1;
            REAR =-1;
        }
        public void insert(int element)
        {
            /*This statement checks for the overflow condition */
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue overvlow\n");
                return;
            }
            /* This following statement checks wheter the queue is empty , if the queue *
             * then the value of the REAR and FRONT variables is set to 0*/
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /* if REAR is at the last position of the array, then the value of
                 REAR is set to 0 that corresponds to the first position of the array.*/
                if (REAR == max - 1)
                    REAR = 0;
                else;
                /* if REAR is not at the last position, then its value is increented by one */
                REAR = REAR + 1;
            }
            /* Once the position of REAR is determinated, the element is added at its proper place */
            queue_array[REAR] = element;
        }

        public void remove()
        {
            /* Checks wheather the queue is empty */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return ;
            }
            Console.WriteLine("\nThe Elements deleted from queue is: " + queue_array[FRONT]
                + "\n");
            /* check if the queue has one element */
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    FRONT = FRONT + 1;
            }
        }

        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            /* Checks if the queue is empty*/
            if (FRONT == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElements in the queue are ...............................\n");
            if (FRONT_position <= REAR_position)
            {
                /* traverses the queue till the last element present is an array*/
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                /* traverses the queue till the last position of the array */
                while(FRONT_position <= max - 1)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }
                /*set the FRONT position to the first element of the array*/
                FRONT_position = 0;
                /* traverse the array till the last element present in the queue*/
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)

        {
            Program queue = new Program();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display value");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.WriteLine("Enter a number: ");
                                int num = Convert.ToInt32(Console.Read());
                                Console.WriteLine();
                                queue.insert(num);
                            }
                            break;
                        case '2':
                            {
                                queue.remove();
                            }
                            break ;
                        case '3':
                            {
                                queue.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option!!");
                            }
                            break;

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values enter");
                }
            }
        }
    }
}
