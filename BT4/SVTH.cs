using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    internal class SVTH:SV
    {
        protected string tenDT;
        protected float diemDT;

        public SVTH()
        {
            this.tenDT = "";
            this.diemDT = 0.0f;
        }

        public SVTH(string hoTen, string namSinh, float dtb, string tenDt, float diemDT) : base(hoTen, namSinh, dtb)
        {
            this.tenDT = tenDT;
            this.diemDT = diemDT;
        }

        public override void hienThi()
        {
            base.hienThi();
            Console.WriteLine("Noi thuc tap {0}",tenDT);
            Console.WriteLine("Diem thuc tap: {0}", diemDT);
        }


        public override string loaiSV()
        {
            return "SVDT";
        }

        public override string duocTN()
        {
            if (diemDT > 7)
            {
                return "TN";
            }
            return "chưa TN";
        }
    }
}
