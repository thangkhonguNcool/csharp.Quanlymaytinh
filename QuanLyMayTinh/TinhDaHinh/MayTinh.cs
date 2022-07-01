using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    internal class MayTinh
    {
        public string ma;
        public List<LinhKien> collection = new List<LinhKien> ();
        public MayTinh()
        {

        }
        public MayTinh(string m)
        {
            ma = m;
        }
        public void Them(LinhKien x)
        { collection.Add(x); }
        public MayTinh(string m, string s)
        {
            string[] str = s.Split(',');
            ma = m;
            foreach (var item in str)
            {
                if (item.Contains("CPU"))
                    Them(new CPU(item));
                if (item.Contains("RAM"))
                    Them(new RAM(item));
                if (item.Contains("Main Board"))
                    Them(new MainBoard(item));
            }
        }
        public float giaMT()
        {
            float gia = 0;
            foreach (var item in collection)
            {
                gia += item.GiaBan();
            }
            return gia;
        }

        public override string ToString()
        {
            string s = "May tinh co ma: " + ma + "\nCo linh kien: ";
            foreach (var item in collection)
                s += "\n" + item;
            return s;
        }
        public bool KTraRamSamSung()
        {
            foreach (var item in collection)
                if (item is RAM && item.hang.Contains("SamSung"))
                    return true;
            return false;
        }
        //===========
        public float GiaMTMIN()
        {
            float min = float.MaxValue, gia;
             gia = giaMT();
                if (gia < min)
                    min = gia;
            
            return min;
        }
        //============
        public float TimGiaCPU()
        {
            float gia = 0;
            foreach(var item in collection)
            {
                if (item is CPU)
                    gia += item.GiaBan();
            }
            return gia;
        }
        public float TimGiaMainBoard()
        {
            float gia = 0;
            foreach (var item in collection)
            {
                if (item is MainBoard)
                    gia += item.GiaBan();
            }
            return gia;
        }



        //================
        public float TimDungLuongRAM()
        {
            float dl = 0;
            foreach (var item in collection)
            {
                if (item is RAM)
                    dl += ((RAM)item).dungLuong;
            }
            return dl;
        }
        //===========
        
        public string TimHangCuaCPU()
        {
            string kq = "";
            foreach (var item in collection)
                if (item is CPU)
                {
                    kq += ((CPU)item).hang;
                    if (kq.Contains(((CPU)item).hang))
                        break;
                }
            return kq;
        }
        public string TimHangCuaRAM()
        {
            string kq = "";
            foreach (var item in collection)
                if (item is RAM)
                {
                    kq += ((RAM)item).hang;
                    if (kq.Contains(((RAM)item).hang))
                        break;
                }    
                    
            return kq;
        }
        public string TimHangCuaMainBoard()
        {
            string kq = "";
            foreach (var item in collection)
                if (item is MainBoard)
                {
                    kq += ((MainBoard)item).hang;
                    if (kq.Contains(((MainBoard)item).hang))
                        break;
                }
            return kq;
        }
        
        public int TimSoLinhKienTheoHangTrong1May(string hangCanTim)
        {
            int dem = 0;

            foreach (var item in this.collection) 
            {
                if (item.hang.Contains(hangCanTim))
                {
                    dem++;
                }
            }
            return dem;
        }
        //=======================
        public int DemSoCPU()
        {
            int dem = 0;
            foreach (var item in collection)
                if (item is CPU)
                    dem ++;
            return dem;
        }
        public int DemSoRAM()
        {
            int dem = 0;
            foreach (var item in collection)
                if (item is RAM)
                    dem++;
            return dem;
        }
        //============
        //Lấy hãng mainboard
        public int DemMainBoardTheoNuoc(string nSX) //Đếm theo nước sx trong 1 máy
        {
            int kq = 0;
            foreach (var item in collection)
                if (item is MainBoard && 
                    (((MainBoard)item).nuocSX).Contains(nSX))
                    kq++;
            return kq;
        }

        public string LayTenNuocSXMainBoard()
        {
            string kq = "";
            foreach (var item in collection)
                if(item is MainBoard)
                    kq+=(((MainBoard)item).nuocSX);
            return kq;
        }

        //===================
        
       
    }
}
