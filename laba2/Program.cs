using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{


    class Program
    {
        static void Main(string[] args)
        {
            //1a

            // bool: хранит значение true или false (логические 
            // литералы). Представлен системным типом System.Boolean

            bool alive = true;
            bool isDead = false;

            // byte: хранит целое число от 0 до 255 и занимает 1 байт. 
            // Представлен системным типом System.Byte

            byte bit1 = 1;
            byte bit2 = 102;

            // sbyte: хранит целое число от -128 до 127 и занимает 1 
            // байт. Представлен системным типом System.SByte

            sbyte sbit1 = -101;
            sbyte sbit2 = 102;

            // short: хранит целое число от -32768 до 32767 и занимает 2
            // байта. Представлен системным типом System.Int16

            short n1 = 1;
            short n2 = 102;

            // ushort: хранит целое число от 0 до 65535 и занимает 2
            // байта. Представлен системным типом System.UInt16

            ushort un1 = 1;
            ushort un2 = 102;

            // int: хранит целое число от -2147483648 до 2147483647 и 
            // занимает 4 байта. Представлен системным типом 
            // System.Int32. Все целочисленные литералы по умолчанию 
            // представляют значения типа int:

            int a = 10;
            int b = 0b101;  // бинарная форма b =5
            int c = 0xFF;   // шестнадцатеричная форма c = 255

            // uint: хранит целое число от 0 до 4294967295 и занимает 4
            // байта. Представлен системным типом System.UInt32

            uint ua = 10;
            uint ub = 0b101;
            uint uc = 0xFF;

            // long: хранит целое число от –9 223 372 036 854 775 808 до // 9 223 372 036 854 775 807 и занимает 8 байт. Представлен 
            // системным типом System.Int64

            long la = -10;
            long lb = 0b101;
            long lc = 0xFF;

            // ulong: хранит целое число от 0 до 18 446 744 073 709 551 // 615 и занимает 8 байт. Представлен системным типом 
            // System.UInt64

            ulong ula = 10;
            ulong ulb = 0b101;
            ulong ulc = 0xFF;

            // float: хранит число с плавающей точкой от -3.4*1038 до 
            // 3.4*1038 и занимает 4 байта. Представлен системным типом 
            // System.Single

            float fa = 3.14F;
            float fb = 30.6f;

            // decimal: хранит десятичное дробное число. Если 
            // употребляется без десятичной запятой, имеет значение от 0 
            // до +/–79 228 162 514 264 337 593 543 950 335; если с 
            // запятой, то от 0 до +/–7,9228162514264337593543950335 с 
            // 28 разрядами после запятой и занимает 16 байт. 
            // Представлен системным типом System.Decimal

            decimal dc = 1005.8M;
            decimal dd = 334.8m;

            // char: хранит одиночный символ в кодировке Unicode и 
            // занимает 2 байта. Представлен системным типомSystem.Char. 
            // Этому типу соответствуют символьные литералы:

            char ca = 'A';
            char cb = '\x5A';
            char cc = '\u0420';

            // string: хранит набор символов Unicode. Представлен 
            // системным типом System.String. Этому типу соответствуют 
            // символьные литералы.

            string hello = "Hello";
            string word = "world";

            // object: может хранить значение любого типа данных и
            // занимает 4 байта на 32-разрядной платформе и 8 байт на 
            // 64-разрядной платформе. Представлен системным типом 
            // System.Object, который является базовым для всех других 
            // типов и классов .NET.

            //1b/d

            object oa = 22;
            object ob = 3.14;
            object oc = "hello code";

            string name = "Tom";
            int age = 33;
            bool isEmployed = false;
            double weight = 78.65;

            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Работает: {isEmployed}");

            var hell = "Hell to World";
            var k = 20;
            var f = 3.14F;
            var o = true;
            var i = -129;

            Console.WriteLine(k.GetType().ToString());
            Console.WriteLine(hell.GetType().ToString());
            Console.WriteLine(f.GetType().ToString());
            Console.WriteLine(o.GetType().ToString());
            Console.WriteLine(i.GetType().ToString());

            //1c

            int val = 5;
            object obj = val;     // присваивание сопровождается упаковкой
            int valUnboxed = (int)obj; // приведение вызовет распаковку

            //1e

            int? z1 = 5;
            Nullable<int> z2 = 5;
            if (z1 == z2)
                Console.WriteLine("объекты равны");
            else
                Console.WriteLine("объекты не равны");

            


            //2

            string s1 = "Значимость этих проблем настолько очевидна ";
            string s2 = "что укрепление и развитие структуры влечет за собой процесс внедрения ";
            string s3 = "и модернизации модели развития.";
            string mess;
            mess = s1 + s2 + s3;
            string str1 = String.Copy(s1);
            bool check = s1.Contains("этих");

            Console.WriteLine(String.Compare(s1, "Hello World?"));
            Console.WriteLine(mess + str1);
            Console.WriteLine(check);

            string[] split = s2.Split(new Char[] { ' ' });

            foreach (string s in split)
            {

                if (s.Trim() != "")
                    Console.WriteLine(s);


            }

            String original = "Равным образом укрепление   структуры требуют определения и уточнения позиций";
            Console.WriteLine("The original string: '{0}'", original);
            String modified = original.Insert(26, "и развитие ");
            Console.WriteLine("The modified string: '{0}'", modified);

            string text = "Хороший день";
            // индекс последнего символа
            int ind = text.Length - 1;
            // вырезаем последний символ
            text = text.Remove(ind);
            Console.WriteLine(text);

            StringBuilder sb = new StringBuilder("По своей сути рыбатекст является альтернативой традиционному lorem ipsum, ");
            // удаляем 20 символов, начиная с 3-го
            sb.Remove(3, 20);
            Console.WriteLine(sb);

            StringBuilder sb2 = new StringBuilder("Равным консультация");
            sb.Append("!");
            sb.Insert(7, " образом");
            Console.WriteLine(sb2);




            Console.ReadLine();

        }
    }   
}