using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    internal class MainBoard:LinhKien
    {
        public string nuocSX;

        public MainBoard(string hang, float gia,string nSX):base(hang,gia)
        {
            nuocSX = nSX;
        }
        public MainBoard()
        {

        }
        public override float GiaBan()
        {
            float giaBan = gia;
            if (hang.Contains("SamSung"))
                giaBan = (float)(gia * 0.95);
            return giaBan;
        }
        public MainBoard(string s)
        {
            string[] str = s.Split(';');
            string[] hangTemp = str[0].Split(':');
            hang = hangTemp[1];
            gia = float.Parse(str[1]);
            nuocSX = str[2];
        }
        public override string ToString()
        {
            string s = "MainBoard: {0}, gia: {1}, nuoc SX: {2}";
            return string.Format(s, hang,gia, nuocSX);
        }
    }
}
