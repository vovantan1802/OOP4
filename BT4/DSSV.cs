using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BT4
{
    internal class DSSV
    {
        private ArrayList list;

        public DSSV()
        {
            list = new ArrayList();
            
        }
        public void them(SV a)
        {
            list.Add(a);
        }
        public void lietKe(string loaisv)
        {
            if (loaisv == "SVSP")
                Console.WriteLine("SVSP--------------------");
            {
                foreach (SV a in list)
                    if (a.loaiSV().Equals(loaisv))
                        a.hienThi();
            }

            if (loaisv == "SVTH")
                Console.WriteLine("SVTH--------------------");
            {
                foreach (SV a in list)
                    if (a.loaiSV().Equals(loaisv))
                        a.hienThi();
            }
        }

        public void lietKe()
        {
            foreach(SV a in list)
            {
                a.hienThi();
            }
        }
    }
}
