using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ConsoleApp6
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { };
            string line;
            string path = "array.txt";
            StreamReader reader = new StreamReader(path);
            while ((line = reader.ReadLine()) != null)
                array = Array.ConvertAll(line.Split(','), s => int.Parse(s));

            Console.WriteLine("Неотсортированный массив: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write( array[i] + ", ");
            Console.WriteLine();

            Console.WriteLine("Отсортировать: \n1.По возрастанию\n2.По убыванию");

            var n = Console.ReadLine();
            int[] result;

            if (Convert.ToInt32(n) == 1)
                result = BubleSort(array,true);
            else if(Convert.ToInt32(n) == 2)
                result = BubleSort(array,false);
            else
            {
                Console.WriteLine("По умолчанию сортировка по возрастанию");
                result = BubleSort(array, false);
            }    
            
            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < result.Length; i++)
                Console.Write(result[i] + ", ");

            Console.ReadLine();

        }

        static int[] BubleSort(int[] array,bool invers)
        {
            var arrayLength = array.Length -1;

            //сортировка пузырьком
            for (var i = 0; i < arrayLength; i++)
            {
                for (var j = 0; j < arrayLength - i; j++)
                {
                    if (invers)
                    {
                        if (array[j] > array[j + 1])
                        {
                            var temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                    else
                    {
                        if (array[j] < array[j + 1])
                        {
                            var temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }



             
                }
            }

            return array;
        }


    }



}
