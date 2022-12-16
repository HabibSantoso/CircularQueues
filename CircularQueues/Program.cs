using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueues
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Queues()
        {
            /*membuat konstruktor untuk menginisialisasi antrian dalam keadaan kosong*/
            FRONT = -1;
            REAR = -1;
        }

        public void insert(int element)
        {
            //mengecek antrian penuh atau tidak
            if ((FRONT == 0 && REAR == max -1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }

            //mengecek antrian kosong atau tidak
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                //mengecek apakah rear ada di penghujung array
                if (REAR == max - 1)
                {
                    REAR = 0;
                }
                else
                {
                    REAR = REAR + 1;
                }
            }
            queue_array[REAR] = element;
        }

        public void remove()
        {
            //mengecek apakah antrian kosong atau tidak
            if (FRONT == -1)
            {
                Console.WriteLine("\nQueue undervlow\n");
                return;
            }
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                //pengapusan di akhir array
                if (FRONT == max - 1)
                {
                    FRONT = 0;
                }else
                {
                    //penghapusan di tengah array
                    FRONT = FRONT = 1;
                }
            }
        }

        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;

            if (FRONT == -1)
            {
                Console.WriteLine("\nQueue is empty\n");
                return;
            }
            Console.WriteLine("\nElement in the Queue are.................. \n");
            if (FRONT_position <= REAR_position)
            {
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "   ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                while (FRONT_position <= max -1)
                {
                    Console.Write(queue_array[FRONT_position] + "   ");
                    FRONT_position++;
                }
                FRONT_position = 0;

                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "   ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
