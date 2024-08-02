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
            this.diemDT = 0;
        }

        public SVTH(string hoTen, int namSinh, float dtb, string tenDt, float diemDT) : base(hoTen, namSinh, dtb)
        {
            this.tenDT = tenDT;
            this.diemDT = diemDT;
        }

        public override void hienThi()
        {
            base.hienThi();
            Console.WriteLine("DT: {0}-{1}", tenDT, diemDT);
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
