using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shakerSortyt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 5,1,9,7,8,4,3,6,2 };

            PrintArray(myArray);
            MyShakerSort(myArray);
            PrintArray(myArray);

            Console.WriteLine();

        }

        static void PrintArray(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }

        static void MyShakerSort(int[] array)
        {

            bool swapped;

            for (int y = 0; y < array.Length / 2; y++)
            {
                swapped = false;

                for (int i = 0; i < array.Length - 1 - y; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        swapped = true;
                    }
                }

                if(swapped == false)
                {
                    return;
                }

                for (int i = array.Length - 1 - y; i > 0; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        int tmp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = tmp;
                        swapped = true;
                    }
                }
            }

        }
        
    }
}
