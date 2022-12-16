﻿using System;
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
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
