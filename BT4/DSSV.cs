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
        public void them(SV sv)
        {
            if (list.Contains(sv))
            {
                Console.WriteLine("Sinh vien da ton tai:");
                Console.ReadLine();
            }
            else
            {
                list.Add(sv);
                Console.WriteLine("Da them sinh vien ");
                Console.ReadLine();
            }
            
        }

        public void hienthi()
        {
            foreach(SV sv in list)
            {
                Console.WriteLine("Ho ten: {0}", sv.HoTen);
                Console.ReadLine();
            }
        }
    }
}
