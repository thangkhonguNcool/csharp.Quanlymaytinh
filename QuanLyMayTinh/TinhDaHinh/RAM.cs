using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    internal class RAM:LinhKien
    {
        public float dungLuong;
        public RAM()
        {

        }
        public RAM(string hang, float gia,float dl):base(hang,gia)
        {
            dungLuong = dl;
            
        }
        public override float GiaBan()
        {
            float giaBan = gia;
            if (hang.Contains("SamSung"))
                giaBan = (float)(gia*0.95);
            return giaBan;
        }
        public RAM(string s)
        {
            string[] str = s.Split(';');
            string[] hangTemp = str[0].Split(':');
            hang = hangTemp[1];
            gia = float.Parse(str[1]);
            dungLuong = float.Parse(str[2]);
        }
        public override string ToString()
        {
            string s = "RAM: {0}, gia: {1}, dung luong: {2}GB";
            return string.Format(s, hang, gia, dungLuong);
        }

    }
}
