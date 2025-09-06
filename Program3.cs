using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_z3
{
    class Program
    {
        static void Main()
        {
            //двумерный массив выведенный как матрица 
            int[,] massiv =
            {
                { 1, 3, 5 },
                { 2, 4, 7 },
                { 1, 8, 9 }
            };
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                for (int j = 0; j < massiv.GetLength(1); j++)
                {
                    Console.Write(massiv[i, j] + " ");
                }
                Console.WriteLine();
            }

            //одномерный массив строк
            /*
            string[] massivstr = { "Hello", "my", "Sister", "Frend", "Girlfrend" };
            for (int i = 0; i < massivstr.Length; i++)
            {
                Console.WriteLine($"Элемент {i}: {massivstr[i]}");
            }
            Console.WriteLine($"Длинна массива: {massivstr.Length}");
            Console.WriteLine($"Смена элемента(0-4)");
            int posit = int.Parse(Console.ReadLine());
            Console.WriteLine($"Новый элемент");
            string newPosit = Console.ReadLine();
            massivstr[posit] = newPosit;
            for (int i = 0; i < massivstr.Length; i++)
            {
                Console.WriteLine($"Элемент {i}: {massivstr[i]}");
            }
            */

            //ступенчатый массив 

            /*
            float[][] newMassiv = new float[3][];
            newMassiv[0] = new float[2];
            newMassiv[1] = new float[3];
            newMassiv[2] = new float[4];

            for (int i = 0; i < newMassiv.Length; i++)
            {
                Console.WriteLine($"Введите количество элементов в строке: {i + 1}");
                int elem = int.Parse(Console.ReadLine());
                newMassiv[i] = new float[elem];

                for (int j = 0; j < newMassiv[i].Length; j++)
                {
                    Console.WriteLine($"Элемент: [{i}][{j}]: ");
                    newMassiv[i][j] = float.Parse(Console.ReadLine());

                }
            }
            for (int i = 0; i < newMassiv.Length; i++)
            {
                for (int j = 0; j < newMassiv[i].Length; j++)
                {
                    Console.Write($"{newMassiv[i][j]} \t");
                }
                Console.WriteLine();
            }

            var odnomermassiv = new[] { 1, 3, 5, 8, 0 };
            var stroki = new[] { "Ivan", "Pavel", "Fedya" };

            */
            //кортежи

            (string, string, int, char, ulong) person = ("Ivan","Shevchenko", 19,'D',06092025);

            Console.WriteLine (person);
            Console.WriteLine (person.Item1 + " " +  person.Item3);

            var person2 = ("Mishelle", 19, 5);
            (string name, int age, int group) = person2;
            Console.WriteLine (name + " " + age + " " + "years old");

            var person3 = ("Mishelle", 19, 5);
            string name1;
            int age1;
            int group1;
            (name1, age, group1) = person3;
            Console.WriteLine (name1 + " " + group1);

            var person4 = ("Mishelle", 19, 5);
            var(name4, _, _)=person4;
            Console.WriteLine(name4);

            Console.WriteLine (person4 == person3);

            //локальная функция 

            (int, int, int, char) MyFunction(int[] arr, string str)
            {
                int max = arr[0];
                int min = arr[0];
                int sum = 0;

                // Находим максимум, минимум и сумму
                foreach (int num in arr)
                {
                    if (num > max) max = num;
                    if (num < min) min = num;
                    sum += num;
                }

                // Берём первую букву строки
                char firstChar = str[0];

                return (max, min, sum, firstChar);
            }
                int[] numbers = { 1, 5, 3, 9, 2 };
                string text = "Hello";

                var result = MyFunction(numbers, text);

                Console.WriteLine($"Максимум: {result.Item1}");
                Console.WriteLine($"Минимум: {result.Item2}");
                Console.WriteLine($"Сумма: {result.Item3}");
                Console.WriteLine($"Первая буква: {result.Item4}");
        
            void Funktion()
            {
                unchecked
                {
                    int value11 = int.MaxValue+1;
                    Console.WriteLine( value11 );
                }
            }
            void Funktion11()
            {
                checked
                {
                    int value12 = int.MaxValue;
                    Console.WriteLine(value12+1);
                }
            }
            Funktion();
            Funktion11();
        }
    }
}
