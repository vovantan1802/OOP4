using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    abstract class SV
    {
        private string hoTen;
        protected string namSinh;
        protected float dtb;

        public string HoTen { get => hoTen; set => hoTen = value; }

        public SV()
        {
            this.HoTen = "";
            this.namSinh = "";
            this.dtb = 0.0f;
        }

        public SV(string hoTen, string namSinh, float dtb)
        {
            this.HoTen = hoTen;
            this.namSinh = namSinh;
            this.dtb = dtb;
        }

        public virtual void hienThi()
        {
            Console.WriteLine("Ho ten: {0}", HoTen);
            Console.WriteLine("Nam sinh: {0}", namSinh);
            Console.WriteLine("Diem trung binh: {0}", dtb);
        }

        public virtual string loaiSV()
        {
            return "";
        }

        public abstract string duocTN();
        
    }
}
