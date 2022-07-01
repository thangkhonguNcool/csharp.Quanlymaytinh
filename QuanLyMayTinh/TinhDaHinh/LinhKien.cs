using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    internal class LinhKien
    {
        public string hang;
        public float gia;
        public LinhKien()
        {

        }
        public virtual float GiaBan()
        {
            return 0;
        }
        public LinhKien (string h, float g)
        {
            gia = g;
            hang = h;
        }
    }
}
