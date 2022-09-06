using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTheSecond
{
    class KhachHang:Nguoi
    {
        string maKH;
        DateTime hangBangLai;

        public string MaKH { get => maKH; set => maKH = value; }
        public DateTime HangBangLai { get => hangBangLai; set => hangBangLai = value; }

        public override void Nhap()
        {
            Console.WriteLine("----------Nhap thong tin khach hang----------");
            Console.Write("Nhap so chung minh: ");
            Socm = long.Parse(Console.ReadLine());
            Console.Write("Ho va ten: ");
            Hoten = Console.ReadLine();
            Console.Write("Ma khach hang: ");
            MaKH = Console.ReadLine();
            Console.Write("Hang bang lai: ");
            HangBangLai = DateTime.Parse(Console.ReadLine());
            Console.Write("Dia chi: ");
            Diachi = Console.ReadLine();
            Console.Write("So dien thoai: ");
            Sodienthoai = Console.ReadLine();


        }

        public override void Xuat()
        {
            Console.WriteLine("-------Thong tin khach hang da nhap----------");
            Console.WriteLine($"So chung minh: {Socm}");
            Console.WriteLine($"Ho va ten: {Hoten}");
            Console.WriteLine($"Ma nhan vien: {MaKH}");
            Console.WriteLine($"Ngay vao cong ty: {HangBangLai}");
            Console.WriteLine($"Dia chi: {Diachi}");
            Console.WriteLine($"So dien thoai: {Sodienthoai}");
        }
    }
}
