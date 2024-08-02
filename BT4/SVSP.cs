using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    internal class SVSP:SV
    {
        protected string noiTT;
        protected float diemTT;

        public SVSP()
        {
            this.noiTT = "";
            this.diemTT = 0;
        }

        public SVSP(string hoTen, int namSinh, float dtb, string noiTT, float diemTT) : base(hoTen, namSinh, dtb)
        {
            this.noiTT = noiTT;
            this.diemTT = diemTT;
        }

        public override void hienThi()
        {
            base.hienThi();
            Console.WriteLine("TT: {0}-{1}", noiTT, diemTT);
        }

        public override string loaiSV()
        {
            return "SVSP";
        }

        public override string duocTN()
        {
            if (diemTT > 4)
            {
                return "TN";
            }
            return "chưa TN";
        }
    }
}
