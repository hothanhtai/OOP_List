using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTheSecond
{
    class HopDongChoThue
    {
        string bs;
        int songaythue;
        double dongia;
        QuanLyXe qlxe;
        NhanVien nhanvien;
        KhachHang khachhang;

        public HopDongChoThue()
        {
            qlxe = new QuanLyXe();
            nhanvien = new NhanVien();
            khachhang = new KhachHang();
        }

        public void Nhap()
        {
            qlxe.NhapXe();
            Console.WriteLine("Nhap vao bien so xe can thue");
            bs = Console.ReadLine();
            Console.WriteLine("Nhap vao so ngay thue");
            songaythue = int.Parse(Console.ReadLine());
            if (qlxe.List.ContainsKey(bs) == true)
            {
                nhanvien.Nhap();
                khachhang.Nhap();
            }
        }


        public double ThanhTien()
        {
            if (qlxe.List[bs] is XeChoHang)
            {
                dongia = 500000;
            }
            else
            {
                if (((XeDuLich)qlxe.List[bs]).SoChoNgoi <= 5)
                {
                    dongia = 500000;
                }
                else
                {
                    if (((XeDuLich)qlxe.List[bs]).SoChoNgoi <= 7)
                    {
                        dongia = 700000;
                    }
                    else dongia = 1000000;
                }
            }
            return dongia * songaythue;
        }






        public void Xuat()
        {
            qlxe.List[bs].Xuat();
            Console.WriteLine("Gia tien can phai tra la: " + ThanhTien());
            nhanvien.Xuat();
            khachhang.Xuat();
        }

    }
}
