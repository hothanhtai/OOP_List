using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTheSecond
{
    class XeDuLich:Car
    {
        int soChoNgoi;

        public int SoChoNgoi { get => soChoNgoi; set => soChoNgoi = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so cho ngoi: ");
            SoChoNgoi = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"So cho ngoi: {SoChoNgoi}");
        }
    }
}
