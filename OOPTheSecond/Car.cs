using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTheSecond
{
    public class Car
    {
        String bienSo;
        String tenXe;
        int trongTai;
        DateTime ngayDangKiem;
        int tieuChuanBang;

        public string BienSo { get => bienSo; set => bienSo = value; }
        public string TenXe { get => tenXe; set => tenXe = value; }
        public int TrongTai { get => trongTai; set => trongTai = value; }
        public DateTime NgayDangKiem { get => ngayDangKiem; set => ngayDangKiem = value; }
        public int TieuChuanBang { get => tieuChuanBang; set => tieuChuanBang = value; }

        public virtual void Nhap()

        {
            Console.WriteLine("-----------Nhap thong tin xe-----------");
            Console.Write("Nhap Bien So: ");
            BienSo = Console.ReadLine();
            Console.Write("Ten Xe: ");
            TenXe = Console.ReadLine();
            Console.Write("Trong Tai: ");
            TrongTai = int.Parse(Console.ReadLine());
            Console.Write("Ngay Dang Kiem: ");
            NgayDangKiem = DateTime.Parse(Console.ReadLine());
            Console.Write("Tieu Chuan Bang: ");
            TieuChuanBang = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("\n");
            Console.WriteLine("--------Thong tin xe da nhap----------");
            Console.WriteLine("Bien So: {0}", BienSo);
            Console.WriteLine("Ten Xe: {0}", TenXe);
            Console.WriteLine("Trong Tai: {0}", TrongTai);
            Console.WriteLine("Ngay Dang Kiem: {0}", NgayDangKiem);
            Console.WriteLine("Tieu Chuan Bang: {0}", TieuChuanBang);
        }
    }
}
