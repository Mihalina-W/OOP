using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lab1
    {
        static void Main()
        {
            /* byte bytePeremen = 1;
            sbyte sbytePeremen = 2;
            short shortPeremen = 3; 
            ushort ushortPeremen = 4;
            int intPeremen = 5;
            uint uintPeremen = 6;
            long longPeremen = 7;
            ulong ulongPeremen = 8;
            float floatPeremen = 9;
            double doublePeremen = 10;
            decimal decimalPeremen = 11;
            char charPeremen = 'a';
            string stringPeremen = "Hello";
            object objectPeremen = 12;
            bool boolPeremen = false;

            Console.WriteLine($"byte: {bytePeremen}");
            Console.WriteLine($"sbyte: {sbytePeremen}");
            Console.WriteLine($"short: {shortPeremen}");
            Console.WriteLine($"ushort: {ushortPeremen}");
            Console.WriteLine($"int: {intPeremen}");
            Console.WriteLine($"uint: {uintPeremen}");
            Console.WriteLine($"long: {longPeremen}");
            Console.WriteLine($"ulong: {ulongPeremen}");
            Console.WriteLine($"float: {floatPeremen}");
            Console.WriteLine($"double: {doublePeremen}");
            Console.WriteLine($"decimal: {decimalPeremen}");
            Console.WriteLine($"char: {charPeremen}");
            Console.WriteLine($"string: {stringPeremen}");
            Console.WriteLine($"object: {objectPeremen}");
            Console.WriteLine($"bool: {boolPeremen}"); */

            //Ввод данных
            /*
            Console.WriteLine("Введите значение переменной типа byte:");
            byte inputByte = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной типа sbyte:");
            sbyte inputSbyte = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной типа short:");
            short inputShort = short.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной типа ushort:");
            ushort inputUshort = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной типа int:");
            int inputInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной типа uint:");
            uint inputUint = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной типа long:");
            long inputLong = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной типа ulong:");
            ulong inputUlong = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной типа float:");
            float inputFloat = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной типа double:");
            double inputDouble = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной типа decimal:");
            decimal inputDecimal = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной типа char:");
            char inputChar = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной типа bool:");
            bool inputBool = bool.Parse(Console.ReadLine()); */

            //неявное  

            byte byteValue = 5;
            short shortValue = byteValue;
            Console.WriteLine($"byte -> short: {byteValue}->{shortValue}");

            int intValue = shortValue;
            Console.WriteLine($"short -> int: {shortValue} -> {intValue}");

            float floatValue = intValue;
            Console.WriteLine($"int -> float: {intValue} -> {floatValue}");

            double doubleValue = floatValue;
            Console.WriteLine($"float -> double: {floatValue} -> {doubleValue}");

            uint uintValue = 8;
            long longValue = uintValue;
            Console.WriteLine($"uint -> long: {uintValue} -> {longValue}");

            //явное 
            double peremenDouble = 123.567;
            int peremenInt = (int)peremenDouble;
            Console.WriteLine($"double -> int: {peremenDouble} -> {peremenInt}");

            sbyte peremenSbyte = (sbyte)peremenInt;
            Console.WriteLine($"int -> sbyte: {peremenInt} -> {peremenSbyte}");

            ushort peremenUshort = (ushort)peremenSbyte;
            Console.WriteLine($"sbyte -> ushort: {peremenSbyte} -> {peremenUshort}"); 

            short peremenShort = (short)peremenUshort;
            Console.WriteLine($"ushort -> short: {peremenUshort} -> {peremenShort}");

            ulong peremenUlong = (ulong)peremenShort;
            Console.WriteLine($"short -> ulong: {peremenShort} -> {peremenUlong}");

            //упаковка и распаковка 

            int bukvaA = 5; 
            object bukvaB = bukvaA;
            Console.WriteLine($"Упакованное число: {bukvaB}");
            int bukvaC = (int)bukvaB;
            Console.WriteLine($"Распакованное число: {bukvaC}");

            double numberOne = 11.1; 
            object numberTwo = numberOne; ;
            Console.WriteLine($"Упакованное число: {numberTwo}");
            double numberFre = (double)numberTwo;
            Console.WriteLine($"Распакованное число: {numberFre}");

            long ein = 1;
            object zwei = ein;
            Console.WriteLine($"Упакованное число: {zwei}");
            long drei = (long)zwei;
            Console.WriteLine($"Распакованное число: {drei}");


            //неявно типиризированная переменная (var)

            var name = "Mishelle";
            var age = 19;
            var rost = 152.9;
            Console.WriteLine($"Меня зовут: {name}");
            Console.WriteLine($"Мне сейчас: {age} лет");
            Console.WriteLine($"Мой рост {rost} сантиметров");

            int? nullperemen = null;
            Console.WriteLine($"Пустая переменная: {nullperemen}"); 
            Nullable<long> nullperemenNullable = null;
            Console.WriteLine($"Пустая перменная 2: {nullperemenNullable}");

            //задание f

            var oshibka = 32;
            oshibka = "Hello";
            Console.WriteLine($"Попытка вывести значение:{oshibka}"); 

        }
    }
}
