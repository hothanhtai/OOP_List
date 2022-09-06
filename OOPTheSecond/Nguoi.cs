using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTheSecond
{
   abstract class Nguoi
    {
        long socm;
        string hoten, diachi, sodienthoai;

        public long Socm { get => socm; set => socm = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }

        public abstract void Nhap();
        public abstract void Xuat();

    }
}
