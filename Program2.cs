using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_z2
{
    class Program
    {
        static void Main()
        {
            //сравниваем литералы 
            string peremen1 = "Hello";
            string peremen2 = "Goodbye";
            int result = string.Compare(peremen1, peremen2);
            Console.WriteLine(result);

            string value1 = "Marta";
            string value2 = "Polina";
            string value3 = "Anna";

            //сцепление строк

            string szeplen1 = value1 + " " + value2 + " " + value3;
            Console.WriteLine($"Сцепление = {szeplen1}");
            string szeplen2 = string.Concat(value1, " ", value2, " ", value3);
            Console.WriteLine($"Сцепление = {szeplen2}");

            //копирование строк

            string copy1 = value1;
            Console.WriteLine($"Копирование1: {copy1}");

            string copy2 = new string(value2.ToCharArray());
            string copy3 = string.Copy(value2);
            Console.WriteLine($"Копирование2: {copy3}");

            //выделение подстроки 

            string substring1 = value2.Substring(2);
            string substring2 = value3.Substring(1, 3);
            Console.WriteLine($"Выделение подстроки 1: {substring1}");
            Console.WriteLine($"Выделение подстроки 2: {substring2}");

            // разделение строки на слова (кое что не работает, надо спросить) 

            string value4 = "The quick brown fox jumps over the lazy dog.";
            string[] words = value4.Split(' ');
            foreach (string word in words);
            {
                Console.WriteLine(words);
            }

            //вставки подстроки в заданную позицию

            string insert = value4.Insert(3, " no");
            Console.WriteLine($"Вставка подстроки: {insert}");

            //Удаление заданной подстроки

            string remove = value4.Remove(3, 5);
            Console.WriteLine($"Удаление заданной подстроки: {remove}");

            //интерполяция строк

            string name1 = "Varvara";
            int age1 = 15;

            string itog = $"Name: {name1}, Age: {age1}";
            Console.WriteLine($"Интерполяция строк: {itog}");

            //создание пустой и null строки 

            string null1 = null;
            string null2 = string.Empty;
            Console.WriteLine($"Пустые строка: {null2}");
            Console.WriteLine($"Null строка: {null1}");

            //использование метода string.IsNullOrEmpty

            string test1 = null;
            string test2 = "Hello";
            Console.WriteLine($"Тест 1: {string.IsNullOrEmpty(test1)}");
            Console.WriteLine($"Тест 2: {string.IsNullOrEmpty(test2)}");

            //что еще можно выполнить с такими строками 

            Console.WriteLine($"Введите ваше имя:");
            string inpytString = (Console.ReadLine());
            if (string.IsNullOrEmpty(inpytString))
            {
               
                Console.WriteLine($"Ошибка");
            }
            else
            {
                Console.WriteLine($"Ваше имя: {inpytString}");
            }

            // строка на основе StringBuilder

            StringBuilder ss = new StringBuilder("Hello my Frend");
            Console.WriteLine($"Исходная строка: {ss}");

            ss.Remove(6, 2);
            Console.WriteLine($"Строка после удаления: {ss}");

            ss.Insert(0, "Oh! ");
            Console.WriteLine($"Строка с добавлением символов: {ss}");

            ss.Append(". Goodbay");
            Console.WriteLine($"Строка с добавления символов в конец: {ss}");





        }
    }
}
