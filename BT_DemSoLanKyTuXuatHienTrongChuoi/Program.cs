using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BT_DemSoLanKyTuXuatHienTrongChuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai báo và nhập chuỗi từ bàn phím
            string str;
            Console.WriteLine("Write something: ");
            str = Console.ReadLine();

            //Show chuỗi đã nhập từ bàn phím
            Console.WriteLine("String input: "+str);

            //gọi ra hàm đếm ký tự
            CharCount(str);

            Console.ReadKey();
        }
        public static void CharCount(string str) // hàm đếm ký tự
            {
            //Khai báo biến ký tự và nhập giá trị từ bàn phím
            Console.WriteLine("Enter characters you want to count:");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
        
            //Khai báo biến count và gán giá trị 0
            int count = 0;

            //Duyệt từng ký tự trong chuỗi và đếm bằng foreach
            foreach (char i in str)
            {
                if (i == inputChar)
                {
                    count++;
                }
            }

            // Hiển thị kết quả
            Console.WriteLine($"Number of times the character '{inputChar}' appears in the string is: {count}");
        }


    }
}
