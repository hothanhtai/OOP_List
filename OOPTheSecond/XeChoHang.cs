using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTheSecond
{
    class XeChoHang:Car
    {
        double soTan;

        public double SoTan { get => soTan; set => soTan = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so tan cua xe: ");
            SoTan = double.Parse(Console.ReadLine());

        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"So tan cua xe cho hang la: {SoTan}");
        }
    }
}
