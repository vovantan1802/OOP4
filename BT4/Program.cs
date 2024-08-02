using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sv = new DSSV();

            var sv1 = new SVSP("Vo Van Tan", "2003", 7, "Quy Nhon", 5);

            sv.them(sv1);

            sv.hienthi();


        }
    }
}
