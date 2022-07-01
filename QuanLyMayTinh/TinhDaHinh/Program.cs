using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ChayChuongTrinh();
        }
        static void ChayChuongTrinh()
        {
            DanhSachMayTinh ds = new DanhSachMayTinh();
            Menu chon = 0;
            do
            {
                Console.Clear();
                MenuCT.XuatMenu();
                chon = MenuCT.ChonMenu();
                Console.Clear();
                MenuCT.XuLyMenu(chon, ds);
                Console.ReadKey ();
            } while (chon != 0);
        }
    }
}
