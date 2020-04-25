using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishProd
{
    class Program
    {
        public struct Fish
        {
            public string type;
            public string manuf;
            public double cost;
        }
        public static void FillMass(int size, Fish[] Products)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Введите название вида рыбы:");
                Products[i].type = Console.ReadLine();
                Console.WriteLine("Введите название производителя:");
                Products[i].manuf = Console.ReadLine();
                Console.WriteLine("Введите цену рыбы:");
                Products[i].cost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nЭлемент добавлен!\n");
            }
        }
        public static void PrintMass(int size, Fish[] Products)
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(Products[i].type + "  " + Products[i].manuf + "  " + Products[i].cost);
            }
        }
        public static void SortMass(int size, Fish[] Products)
        {
            for (int i = size - 1; i >= 0; i++)
            {
                for (int j = 0; j < i; i++)
                {
                    if (Products[j].type[0] < Products[j + 1].type[0] && Products[j].cost < Products[j + 1].cost)
                    {
                        Fish tmp = Products[j];
                        Products[j] = Products[j + 1];
                        Products[j + 1] = tmp;
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int size = Convert.ToInt32(Console.ReadLine());
            Fish[] Products = new Fish[size];
            FillMass(size, Products);
            PrintMass(size, Products);
            Console.WriteLine("\n Ожидайте завершения сортировки... \n:");
            SortMass(size, Products);
            PrintMass(size, Products);
            Console.ReadKey();
        }
    }
}
