using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTheSecond
{
    class NhanVien: Nguoi
    {
        string manv;
        DateTime ngayvao;

        public string Manv { get => manv; set => manv = value; }
        public DateTime Ngayvao { get => ngayvao; set => ngayvao = value; }

        public override void Nhap()
        {
            Console.WriteLine("-------------Nhap thong tin nhan vien-----------");
            Console.Write("Nhap so chung minh: ");
            Socm = long.Parse(Console.ReadLine());
            Console.Write("Ho va ten: ");
            Hoten = Console.ReadLine();
            Console.Write("Ma nhan vien: ");
            Manv = Console.ReadLine();
            Console.Write("Ngay vao cong ty: ");
            Ngayvao = DateTime.Parse(Console.ReadLine());
            Console.Write("Dia chi: ");
            Diachi = Console.ReadLine();
            Console.Write("So dien thoai: ");
            Sodienthoai = Console.ReadLine();

        }

        public override void Xuat()
        {
            Console.WriteLine("-------Thong tin nhan vien da nhap----------");
            Console.WriteLine($"So chung minh: {Socm}");
            Console.WriteLine($"Ho va ten: {Hoten}");
            Console.WriteLine($"Ma nhan vien: {Manv}");
            Console.WriteLine($"Ngay vao cong ty: {Ngayvao}");
            Console.WriteLine($"Dia chi: {Diachi}");
            Console.WriteLine($"So dien thoai: {Sodienthoai}");
        }
    }
}
