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
            if ((FRONT == && REAR == max - 1) ||(FRONT == REAR +1))
            {
                Console.WriteLine("\nQueue overvlow\n");
                return;
            }
            

        }
        static void Main(string[] args)
        {
        }
    }
}
