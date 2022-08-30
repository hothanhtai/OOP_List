using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTheSecond
{
    class QuanLyXe
    {
        Dictionary<string, Car> List = new Dictionary<string, Car>();

        public void NhapXe()
        {
            Console.Write("Nhap vao so luong xe: ");
            int soLuong = int.Parse(Console.ReadLine());
            for(int i=0; i<soLuong; i++)
            {
                Console.WriteLine("An phim (H) tren ban phim de nhap cho xe cho hang,(D) de nhap cho xe du lich");
                char c = char.Parse(Console.ReadLine().ToUpper().PadLeft(1));

                switch (c)
                {
                    case 'D':
                        {
                            XeDuLich xedl = new XeDuLich();
                            xedl.Nhap();
                            List.Add(xedl.BienSo, xedl);

                        }
                        break;

                    case 'H':
                        {
                            XeChoHang xech = new XeChoHang();
                            xech.Nhap();
                            List.Add(xech.BienSo, xech);

                        }
                        break;
                    default:
                        Console.Write("Nhap sai moi nhap lai! \n");

                        break;

                }
            }
        }
        public void Tim()
        {
            Console.Write("Nhap bien so can tim: ");
            string bs = Console.ReadLine();
            if(List.ContainsKey(bs) == true)
            {
                Console.Write("Co xe can tim!");
                List[bs].Xuat();
                
            }
            else
            {
                Console.Write("Khong tim thay xe!");
            }
        }

        public void Xoa()
        {
            Console.Write("Nhap bien so can xoa: ");
            string bs = Console.ReadLine();
            if (List.ContainsKey(bs) == true)
            {
                Console.Write("Co xe can xoa!");
                List.Remove(bs);

            }
            else
            {
                Console.Write("Khong tim thay xe can xoa!");
            }
        }
        public void Xuat()
        {
            foreach (var item in List.Values)
            {
                item.Xuat();

            }

        }
    }
}
