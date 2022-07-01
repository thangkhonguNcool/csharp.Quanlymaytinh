using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    internal class DanhSachMayTinh
    {
        List<MayTinh> collection = new List<MayTinh>();
        public void Them(MayTinh m)
        {
            collection.Add(m);
        }
        public void NhapTuFile()
        {
            string path = @"dulieu.csv";
            StreamReader sr = new StreamReader(path);
            string s = "";
            int i = 1;
            while ((s = sr.ReadLine()) != null)
            {
                MayTinh mt = new MayTinh(i.ToString(), s);
                i++;
                Them(mt);
            }

        }
        public override string ToString()
        {
            string s = "";
            foreach (var item in collection)
                s += "\n" + item;
            return s;
        }
        public DanhSachMayTinh TimMTCoRamSamSung()
        {
            DanhSachMayTinh kq = new DanhSachMayTinh();
            foreach (var item in collection)
            {
                if (item.KTraRamSamSung())
                    kq.Them(item);
            }
            return kq;
        }
        //====================
        //Tìm máy tính giá MAX - MIN
        public DanhSachMayTinh TimTatCaMTCoGiaCaoNhat()
        {
            DanhSachMayTinh kq = new DanhSachMayTinh();
            float max = GiaMTMAX();
            float gia = 0;
            for (int i = 0; i < collection.Count; i++)
            {
                gia = collection[i].giaMT();
                if (gia == max)
                    kq.Them(collection[i]);
            }
            return kq;
        }
        public float GiaMTMAX()
        {
            float max = -1, gia;
            for (int i = 0; i < collection.Count; i++)
            {
                gia = collection[i].giaMT();
                if (gia > max)
                    max = gia;
            }
            return max;
        }

        //===================
        public DanhSachMayTinh TimTatCaMTCoGiaThapNhat()
        {
            DanhSachMayTinh kq = new DanhSachMayTinh();
            float min = GiaMTMIN();
            float gia = 0;
            for (int i = 0; i < collection.Count; i++)
            {
                gia = collection[i].giaMT();
                if (gia == min)
                    kq.Them(collection[i]);
            }
            return kq;
        }
        public float GiaMTMIN()
        {
            float min = float.MaxValue, gia;
            for (int i = 0; i < collection.Count; i++)
            {
                gia = collection[i].giaMT();
                if (gia < min)
                    min = gia;
            }
            return min;
        }
        //=======================
        //Tìm CPU giá  MIN
        public DanhSachMayTinh TimTatCaMTCoCPUGiaThapNhat()
        {
            DanhSachMayTinh kq = new DanhSachMayTinh();
            float giaMIN = TimGiaCPUThapNhat();
            foreach (var item in collection)
            {
                if (item.TimGiaCPU() == giaMIN)
                    kq.Them(item);
            }
            return kq;
        }
        public float TimGiaCPUThapNhat()
        {
            float min = float.MaxValue, gia;
            foreach (var item in collection)
            {
                gia = item.TimGiaCPU();
                if (gia < min)
                    min = gia;
            }
            return min;
        }
        //======================
        //Tìm RAM dung lượng MAX - MIN
        public DanhSachMayTinh TimTatCaMTCoDungLuongRAMMAX()
        {
            DanhSachMayTinh kq = new DanhSachMayTinh();
            float dlMAX = TimRAMDungLuongMAX();
            foreach (var item in collection)
            {
                if (item.TimDungLuongRAM() == dlMAX)
                    kq.Them(item);
            }
            return kq;
        }
        public float TimRAMDungLuongMAX()
        {
            float max = -1, dl;
            foreach (var item in collection)
            {
                dl = item.TimDungLuongRAM();
                if (dl > max)
                    max = dl;
            }
            return max;
        }
        //==================
        public DanhSachMayTinh TimTatCaMTCoDungLuongRAMMIN()
        {
            DanhSachMayTinh kq = new DanhSachMayTinh();
            float dlMIN = TimRAMDungLuongMIN();
            foreach (var item in collection)
            {
                if (item.TimDungLuongRAM() == dlMIN)
                    kq.Them(item);
            }
            return kq;
        }
        public float TimRAMDungLuongMIN()
        {
            float min = float.MaxValue, dl;
            foreach (var item in collection)
            {
                dl = item.TimDungLuongRAM();
                if (dl < min)
                    min = dl;
            }
            return min;
        }
        //=======================
        //Tìm hãng nhiều linh kiện nhất
        
        List<string> LayDSPhanBiet(List<string> x)
        {
            List<string> kq = new List<string>();
            for (int i = 0; i < x.Count; i++)
            {
                if ((kq.Contains(x[i])) == false)
                    kq.Add(x[i]);
            }
            return kq;
        }
        List<string> LayDSHang()
        {
            List<string> store = new List<string>();
            for(int i =0;i<collection.Count;i++)    
            {
                store.Add((collection[i].TimHangCuaCPU()));
                store.Add((collection[i].TimHangCuaRAM()));
                store.Add((collection[i].TimHangCuaMainBoard()));
               
            }
            return store;
        }
        public int TimSoLinhKienTheoHang(string hangCanTim)
        {
            int dem = 0;
            foreach (var item in collection)
            {
                dem += item.TimSoLinhKienTheoHangTrong1May(hangCanTim);
            }
            return dem;
        }
        public int TimSoLinhKienMaxCuaHang()
        {
            int max = 0;
            List<string> hang = LayDSPhanBiet(LayDSHang());
            for(int i=0;i<hang.Count;i++)
            {
                if (TimSoLinhKienTheoHang(hang[i]) > max)
                {
                    max = TimSoLinhKienTheoHang(hang[i]);
                }
            }
            return max;
        }

        public List<string> TimHangCoNhieuLinhKienNhat()
        {
            List<string> kq = new List<string>();
            int max = TimSoLinhKienMaxCuaHang();
            List<string> hang = LayDSPhanBiet(LayDSHang());
            for(int i =0;i<hang.Count;i++)
            {
                if (TimSoLinhKienTheoHang(hang[i]) == max)
                {
                    kq.Add(hang[i]);
                }
            }
            return kq;
        }
        //=================
        //Tìm máy tính có 2 CPU
        public DanhSachMayTinh TimTatCaMTCo2CPU()
        {
            DanhSachMayTinh kq = new DanhSachMayTinh();
            foreach (var item in collection)
            {
                if (item.DemSoCPU() == 2)
                    kq.Them(item);
            }
            return kq;
        }
        //==================

        //================================
        //Đếm số lượng CPU
        public int DemSoLuongCPU()
        {
            int dem = 0;
            foreach (var item in collection)
                dem += item.DemSoCPU();
            return dem;
        }
        //================================
        //Đếm số lượng RAM
        public int DemSoLuongRAM()
        {
            int dem = 0;
            foreach (var item in collection)
                dem += item.DemSoRAM();
            return dem;
        }
        //==============================
        //Xóa tất cả MT có dung lượng RAM x
        public void XoaTatCaMTDungLuongRAMX(float x)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].TimDungLuongRAM() == x)
                {
                    collection.Remove(collection[i]);
                    i--;
                }
            }
        }
        //======================
        //Sắp xếp
        enum KieuSapXep
        {
            TangTheoGia,
            GiamTheoGia,
            TangTheoSoLuongCPU,
            GiamTheoSoLuongCPU,
            TangTheoSoLuongRAM,
            GiamTheoSoLuongRAM,
            TangTheoSoLuongLinhKienTheoHang,
            GiamTheoSoLuongLinhKienTheoHang
        }
        int KTraDieuKienMT(MayTinh a, MayTinh b, KieuSapXep k)
        {
            switch (k)
            {
                case KieuSapXep.TangTheoGia:
                    return a.giaMT().CompareTo(b.giaMT());
                case KieuSapXep.GiamTheoGia:
                    return -(a.giaMT().CompareTo(b.giaMT()));
                case KieuSapXep.TangTheoSoLuongCPU:
                    return a.DemSoCPU().CompareTo(b.DemSoCPU());
                case KieuSapXep.TangTheoSoLuongRAM:
                    return a.DemSoRAM().CompareTo(b.DemSoRAM());
                case KieuSapXep.GiamTheoSoLuongCPU:
                    return -(a.DemSoCPU().CompareTo(b.DemSoCPU()));
                case KieuSapXep.GiamTheoSoLuongRAM:
                    return -(a.DemSoRAM().CompareTo(b.DemSoRAM()));
                default:
                    return -1;
            }

        }
        void SapXepMT(KieuSapXep k)
        {
            for (int i = 0; i < collection.Count - 1; i++)
                for (int j = i + 1; j < collection.Count; j++)
                    if (KTraDieuKienMT(collection[i], collection[j], k) == 1)
                    {
                        MayTinh temp = collection[i];
                        collection[i] = collection[j];
                        collection[j] = temp;
                    }
        }
        int KTraDieuKienHang(int x, int y, KieuSapXep k)
        {
            switch (k)
            {
                case KieuSapXep.TangTheoSoLuongLinhKienTheoHang:
                    return x.CompareTo(y);
                case KieuSapXep.GiamTheoSoLuongLinhKienTheoHang:
                    return y.CompareTo(x);
                default:
                    return -1;
            }
        }

        void SapXepHang(KieuSapXep k)
        {
            List<string> dsHang = LayDSPhanBiet(LayDSHang());
            for (int i = 0; i < dsHang.Count - 1; i++)
                for (int j = i + 1; j < dsHang.Count; j++)
                    if (KTraDieuKienHang(TimSoLinhKienTheoHang(dsHang[i]), TimSoLinhKienTheoHang(dsHang[j]), k) == 1)
                    {
                        string temp = dsHang[i];
                        dsHang[i] = dsHang[j];
                        dsHang[j] = temp;
                    }
            XuatDanhSachHang(dsHang);

        }
        public void XuatDanhSachHang(List<string> dsHang)
        {
            foreach (var item in dsHang)
                Console.WriteLine(item + "\n");
        }
        public void SapXepTangTheoGia()
        {
            SapXepMT(KieuSapXep.TangTheoGia);
        }
        public void SapXepGiamTheoGia()
        {
            SapXepMT(KieuSapXep.GiamTheoGia);
        }
        public void SapXepTangTheoSoLuongCPU()
        {
            SapXepMT(KieuSapXep.TangTheoSoLuongCPU);
        }
        public void SapXepGiamTheoSoLuongCPU()
        {
            SapXepMT(KieuSapXep.GiamTheoSoLuongCPU);
        }
        public void SapXepTangTheoSoLuongRAM()
        {
            SapXepMT(KieuSapXep.TangTheoSoLuongRAM);
        }
        public void SapXepGiamTheoSoLuongRam()
        {
            SapXepMT(KieuSapXep.GiamTheoSoLuongRAM);
        }
        public void SapXepTangTheoSoLuongLinhKien()
        {
            SapXepHang(KieuSapXep.TangTheoSoLuongLinhKienTheoHang);
        }
        public void SapXepGiamTheoSoLuongLinhKien()
        {
            SapXepHang(KieuSapXep.GiamTheoSoLuongLinhKienTheoHang);
        }
        //===================
        //Tìm nước có số lượng mainboard là x
        public List<string> TimNuocCoSoLuongMainBoardX(int x)
        {
            List<string> kq = new List<string>();
            int count = 0;
            List<string> nuoc = LayDSPhanBiet(LayTenNuocSX());
            for (int i = 0; i < nuoc.Count; i++)
            {
                count = DemMainBoardTheoNuoc(nuoc[i]);
                if (count == x)
                    kq.Add(nuoc[i]);
            }
            return kq;
        }
        
        List<string> LayTenNuocSX()
        {
            List<string> kq = new List<string>();
            foreach (var item in collection)
                kq.Add(item.LayTenNuocSXMainBoard());
            return kq;
        }
        int DemMainBoardTheoNuoc(string nuoc)
        {
            int kq = 0;
            foreach (var item in collection)
            {
                kq += item.DemMainBoardTheoNuoc(nuoc);
            }
            return kq;
        }

        //=====================
        //Tìm nước sản xuất nhiều MainBoard nhất
        public List<string> TimNuocSXNhieuMainBoardNhat()
        {
            List<string> kq = new List<string>();
            int max = TimSoMainBoardMAXTheoNuocSX();
            List<string> nuoc = LayDSPhanBiet(LayTenNuocSX());
            for (int i = 0; i < nuoc.Count; i++)
            {
                if (DemMainBoardTheoNuoc(nuoc[i]) == max)
                    kq.Add(nuoc[i]);
            }
            return kq;
        }
        int TimSoMainBoardMAXTheoNuocSX()
        {
            int max = 0;
            List<string> nuoc = LayDSPhanBiet(LayTenNuocSX());
            max = DemMainBoardTheoNuoc(nuoc[0]);
            for (int i = 1; i < nuoc.Count; i++)
            {
                int count = DemMainBoardTheoNuoc(nuoc[i]);
                if (count > max)
                    max = count;
            }
            return max;
        }

        public bool IsEmptyListStr(List<string> x)
        {
            if (x.Count == 0)
                return true;
            return false;
        }
        //===========================
        //Tìm tất cả máy tính sử dụng MainBoarb nước X
        public DanhSachMayTinh TimTatCaMTSuDungMainBoardNuocX(string nuoc)
        {
            DanhSachMayTinh kq = new DanhSachMayTinh();
            for (int i = 0; i < collection.Count; i++)
                if (collection[i].LayTenNuocSXMainBoard().Contains(nuoc))
                    kq.Them(collection[i]);
            return kq;
        }
        public bool IsEmptyCollection()
        {
            if (collection.Count == 0)
                return true;
            return false;
        }
        //============================
        //Tìm tất cả MT không sử dụng MainBoard nước X
        public DanhSachMayTinh TimTatCaMTKhongSuDungMainBoardNuocX(string nuoc)
        {
            DanhSachMayTinh kq = new DanhSachMayTinh();
            for (int i = 0; i < collection.Count; i++)
                if (collection[i].LayTenNuocSXMainBoard().Contains(nuoc) == false)
                    kq.Them(collection[i]);
            return kq;
        }
        //=============================
        //Xóa tất cả MT sử dụng MainBoard sản xuất tại nước X
        public void XoaTatCaMTSuDungMainBoardSXTaiX(string nuoc)
        {
            for (int i = 0; i < collection.Count; i++)
                if (collection[i].LayTenNuocSXMainBoard().Contains(nuoc))
                {
                    collection.RemoveAt(i);
                    i--;
                }    
        }
        //===================
        //Tìm vị trí MT sử dụng MainBoard SX tại nước X
        public List<int> TimViTriMTSuDungMainBoardSXTaiX(string nuoc)
        {
            List<int> kq = new List<int>();
            for (int i = 0; i < collection.Count; i++)
                if (collection[i].LayTenNuocSXMainBoard().Contains(nuoc))
                    kq.Add(i+1);
            return kq;
        }
        public bool IsEmptyListInt(List<int> x)
        {
            if (x.Count == 0)
                return true;
            return false;
        }
        //=========================
        //Tìm hãng có số MainBoard ít nhất theo nước
        public List<string> TimHangCoSoMainBoardItNhatTheoNuocSX(string n)
        {
            List<string> kq = new List<string>();
            List<string> hangMB = TimHangMainBoardTheoNuoc(n);
            int min = TimSoMainBoardItNhatCuaHangTheoNuoc(n);
            for(int i =0; i < hangMB.Count; i++)
            {
                int count = DemMainBoardHangTheoNuocY(n, hangMB[i]);
                if (count == min)
                    kq.Add(hangMB[i]);
            }
            kq = LayDSPhanBiet(kq);
            return kq;
        }
        int DemMainBoardHangTheoNuocY(string n, string h)
        {
            int kq = 0;
            for(int i=0;i<collection.Count;i++)
                if(collection[i].LayTenNuocSXMainBoard().Contains(n) &&
                    (collection[i].TimHangCuaMainBoard().Contains(h)))
                    kq++;
            return kq;
        }
        int TimSoMainBoardItNhatCuaHangTheoNuoc(string n)
        {
            int min = int.MaxValue;
            List<string> hangMB = TimHangMainBoardTheoNuoc(n);
            for (int i=0;i<hangMB.Count;i++)
            {
                int count = DemMainBoardHangTheoNuocY(n, hangMB[i]);
                if (count < min)
                    min = count;
            }
            return min;
        }
        
        List<string> TimHangMainBoardTheoNuoc(string n)
        {
            List<string> kq = new List<string>();
            foreach(var item in collection)
                if(item.LayTenNuocSXMainBoard().Contains(n))
                    kq.Add(item.TimHangCuaMainBoard());
            return kq;
        }
        //=========================
        //Tìm hãng có số MainBoard nhiều nhất theo nước
        public List<string> TimHangCoSoMainBoardNhieuNhatTheoNuocSX(string n)
        {
            List<string> kq = new List<string>();
            List<string> hangMB = TimHangMainBoardTheoNuoc(n);
            int max = TimSoMainBoardNhieuNhatCuaHangTheoNuoc(n);
            for (int i = 0; i < hangMB.Count; i++)
            {
                int count = DemMainBoardHangTheoNuocY(n, hangMB[i]);
                if (count == max)
                    kq.Add(hangMB[i]);
            }
            kq=LayDSPhanBiet(kq);
            return kq;
        }
        int TimSoMainBoardNhieuNhatCuaHangTheoNuoc(string n)
        {
            int max =0;
            List<string> hangMB = TimHangMainBoardTheoNuoc(n);
            for (int i = 0; i < hangMB.Count; i++)
            {
                int count = DemMainBoardHangTheoNuocY(n, hangMB[i]);
                if (count > max)
                    max= count;
            }
            return max;
        }
        //===========================
        //Tính tổng giá bán MainBoard theo nước
        public float TinhTongGiaBanMainBoardTheoNuoc(string n)
        {
            float kq = 0;
            for (int i = 0; i < collection.Count; i++)
                if (collection[i].LayTenNuocSXMainBoard().Contains(n))
                    kq += collection[i].giaMT();
            return kq;
        }

    }
}
