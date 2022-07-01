using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    internal class CPU:LinhKien
    {
        public float tocDo;
        public CPU()
        {

        }
        public CPU(string hang, float gia,float tDo):base(hang,gia)
        {
            tocDo = tDo;
            
        }
        public override float GiaBan()
        {
            float gb = gia;
            if (hang.Contains("SamSung"))
                gb = (float)(gia*0.95);
            return gb;
        }
        public CPU (string s)
        {
            string[] str = s.Split(';');
            string[] hangTemp = str[0].Split(':');
            hang = hangTemp[1];
            gia = float.Parse(str[1]);
            tocDo = float.Parse(str[2]);
        }
        public override string ToString()
        {
            string s = "CPU: {0}, gia: {1}, toc do {2}GHz";
            return string.Format(s, hang, gia, tocDo);
        }
    }
}
