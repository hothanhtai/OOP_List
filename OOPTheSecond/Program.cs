using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTheSecond
{
    class Program
    {
       
        static void Main(string[] args)
        {
            QuanLyXe xe = new QuanLyXe();
            xe.NhapXe();
            xe.Tim();
            xe.Xoa();
            xe.Xuat();
            Console.ReadKey();
        }

 
        
    }
}
