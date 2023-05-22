using System;
using System.Text;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using QuanLySinhVien;

namespace QuanLySinhvien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            quanLySinhVien SV = new quanLySinhVien();
            SV.Menu();  
            Console.ReadKey();
        }

    }
}