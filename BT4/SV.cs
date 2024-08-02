using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    abstract class SV
    {
        protected string hoTen;
        protected int namSinh;
        protected float dtb;

        public SV()
        {
            this.hoTen = "";
            this.namSinh = 0;
            this.dtb = 0;
        }

        public SV(string hoTen, int namSinh, float dtb)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.dtb = dtb;
        }

        public virtual void hienThi()
        {
            Console.WriteLine("{0}-{1}-{2}", hoTen, namSinh, dtb);
        }

        public virtual string loaiSV()
        {
            return "";
        }

        public abstract string duocTN();
        
    }
}
