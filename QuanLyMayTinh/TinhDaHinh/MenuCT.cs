using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    enum Menu
    {
        Thoat,
        NhapTuFile,
        XemDuLieu,
        TimRAMSamSung,
        TimMTGiaCaoNhat,
        TimMTGiaThapNhat,
        TimCPUGiaThapNhat,
        TimRAMDungLuongCaoNhat,
        TimRAMDungLuongThapNhat,
        TimHangNhieuLinhKienNhat,
        TimMTCo2CPU,
        TimSoLuongLinhKienTheoHang,
        DemSoLuongCPU,
        DemSoLuongRAM,
        XoaTatCaMTDungLuongRAMX,
        SapXepMTTangTheoGia,
        SapXepMTGiamTheoGia,
        SapXepMTTangTheoSoLuongCPU,
        SapXepMTGiamTheoSoLuongCPU,
        SapXepMTTangTheoSoLuongRAM,
        SapXepMTGiamTheoSoLuongRAM,
        SapXepHangTangTheoSoLuongLinhKien,
        SapXepHangGiamTheoSoLuongLinhKien,
        TimNuocCoSoLuongMainBoardX,
        TimNuocSanXuatNhieuMainBoardNhat,
        TimTatCaMTSuDungMainBoardX,
        TimTatCaMTKhongDungMainBoardX,
        XoaTatCaMTSuDungMainBoardX,
        TimViTriMTSuDungMainBoardX,
        TimHangCoSoLuongSXMainBoardItNhatTheoNuoc,
        TimHangCoSoLuongSXMainBoardNhieuNhatTheoNuoc,
        TinhTongGiaMTSuDungMainBoardTheoNuoc
    }
    internal class MenuCT
    {
        public static void XuatMenu()
        {
            Console.WriteLine("Nhập {0} để thoát",(int)Menu.Thoat);
            Console.WriteLine("Nhập {0} để nhập dữ liệu từ file", (int)Menu.NhapTuFile);
            Console.WriteLine("Nhập {0} để xem dữ liêu",(int)Menu.XemDuLieu);
            Console.WriteLine("Nhâp {0} để tìm RAM hãng SamSung",(int)Menu.TimRAMSamSung);
            Console.WriteLine("Nhâp {0} để tìm máy tính giá cao nhất", (int)Menu.TimMTGiaCaoNhat);
            Console.WriteLine("Nhâp {0} để tìm máy tính giá thấp nhất", (int)Menu.TimMTGiaThapNhat);
            Console.WriteLine("Nhập {0} để tìm CPU giá thấp nhất", (int)Menu.TimCPUGiaThapNhat);
            Console.WriteLine("Nhập {0} để tìm RAM dung lượng cao nhất", (int)Menu.TimRAMDungLuongCaoNhat);
            Console.WriteLine("Nhập {0} để tìm RAM dung lượng thấp nhất", (int)Menu.TimRAMDungLuongThapNhat);
            Console.WriteLine("Nhập {0} để tìm hãng nhiều linh kiện nhất", (int)Menu.TimHangNhieuLinhKienNhat);
            Console.WriteLine("Nhập {0} để tìm máy tính có 2 CPU", (int)Menu.TimMTCo2CPU);
            Console.WriteLine("Nhập {0} để tìm số lượng linh kiện theo hãng", (int)Menu.TimSoLuongLinhKienTheoHang);
            Console.WriteLine("Nhập {0} để đếm số lượng CPU được sử dụng", (int)Menu.DemSoLuongCPU);
            Console.WriteLine("Nhập {0} để đếm số lượng RAM được sử dụng", (int)Menu.DemSoLuongRAM);
            Console.WriteLine("Nhập {0} để xóa tất cả máy tính có dung lượng RAM x", (int)Menu.XoaTatCaMTDungLuongRAMX);
            Console.WriteLine("Nhập {0} để sắp xếp máy tính tăng theo giá", (int)Menu.SapXepMTTangTheoGia);
            Console.WriteLine("Nhập {0} để sắp xếp máy tính giảm theo giá", (int)Menu.SapXepMTGiamTheoGia);
            Console.WriteLine("Nhập {0} để sắp xếp máy tính tăng theo số lượng CPU", (int)Menu.SapXepMTTangTheoSoLuongCPU);
            Console.WriteLine("Nhập {0} để sắp xếp máy tính giảm theo số lượng CPU", (int)Menu.SapXepMTGiamTheoSoLuongCPU);
            Console.WriteLine("Nhập {0} để sắp xếp máy tính tăng theo số lượng RAM", (int)Menu.SapXepMTTangTheoSoLuongRAM);
            Console.WriteLine("Nhập {0} để sắp xếp máy tính giảm theo số lượng RAM", (int)Menu.SapXepMTGiamTheoSoLuongRAM);
            Console.WriteLine("Nhập {0} để sắp xếp hãng tăng theo số lượng linh kiện", (int)Menu.SapXepHangTangTheoSoLuongLinhKien);
            Console.WriteLine("Nhập {0} để sắp xếp hãng giảm theo số lượng linh kiện", (int)Menu.SapXepHangGiamTheoSoLuongLinhKien);
            Console.WriteLine("Nhập {0} để tìm nước có số lượng X MainBoard", (int)Menu.TimNuocCoSoLuongMainBoardX);
            Console.WriteLine("Nhập {0} để tìm nước sản xuất nhiều MainBoard nhất", (int)Menu.TimNuocSanXuatNhieuMainBoardNhat);
            Console.WriteLine("Nhập {0} để tìm tất cả máy tính sử dụng MainBoard hãng x", (int)Menu.TimTatCaMTSuDungMainBoardX);
            Console.WriteLine("Nhập {0} để tìm tất cả máy tính không sử dụng MainBoard hãng x", (int)Menu.TimTatCaMTKhongDungMainBoardX);
            Console.WriteLine("Nhập {0} để xóa tất cả máy tính sử dụng MainBoard X", (int)Menu.XoaTatCaMTSuDungMainBoardX);
            Console.WriteLine("Nhập {0} để tìm vị trí của máy tính sử dụng MainBoard x", (int)Menu.TimViTriMTSuDungMainBoardX);
            Console.WriteLine("Nhập {0} để tìm hãng có số lượng sản xuất MainBoard ít nhất theo nước", (int)Menu.TimHangCoSoLuongSXMainBoardItNhatTheoNuoc);
            Console.WriteLine("Nhập {0} để tìm hãng có số lượng sản xuất MainBoard nhiều nhất theo nước", (int)Menu.TimHangCoSoLuongSXMainBoardNhieuNhatTheoNuoc);
            Console.WriteLine("Nhập {0} để tính tổng giá trị của máy tính sử dụng MainBoard theo nước sản xuất", (int)Menu.TinhTongGiaMTSuDungMainBoardTheoNuoc);

            Console.WriteLine("============================================\n");
        }
        public static Menu ChonMenu()
        {
            int soMenu = (int)Menu.TinhTongGiaMTSuDungMainBoardTheoNuoc;
            int stt;
            do
            {
                Console.Write("Nhập số để chọn chức năng tương ứng: ");
                stt = int.Parse(Console.ReadLine());
                if (0 <= stt && stt <= soMenu)
                    break;
            } while (true);
            return (Menu)stt;
        }
        public static void XuLyMenu(Menu chonMenu, DanhSachMayTinh ds)
        {
            float gia, dl;
            string h;
            int dem;
            DanhSachMayTinh dsMT = new DanhSachMayTinh();
            List<string> listStr = new List<string>();
            List<int> listInt = new List<int>();
            switch(chonMenu)
            {
                case Menu.Thoat:
                    break;
                case Menu.NhapTuFile:
                    ds.NhapTuFile();
                    Console.WriteLine(ds);
                    break;
                case Menu.XemDuLieu:
                    Console.WriteLine(ds);
                    break;
                case Menu.TimRAMSamSung:
                    dsMT = ds.TimMTCoRamSamSung();
                    Console.WriteLine("Các máy tính có RAM hãng SamSung là:\n\n{0}",dsMT);
                    break;
                case Menu.TimMTGiaCaoNhat:
                    gia = ds.GiaMTMAX();
                    dsMT = ds.TimTatCaMTCoGiaCaoNhat();
                    Console.WriteLine("Gía máy tính cao nhất là: {0}\n\n{1}",gia,dsMT);
                    break;
                case Menu.TimMTGiaThapNhat:
                    gia = ds.GiaMTMIN();
                    dsMT = ds.TimTatCaMTCoGiaThapNhat();
                    Console.WriteLine("Gía máy tính thấp nhất là: {0}\n\n{1}", gia, dsMT);
                    break;
                case Menu.TimRAMDungLuongCaoNhat:
                    dl = ds.TimRAMDungLuongMAX();
                    dsMT = ds.TimTatCaMTCoDungLuongRAMMAX();
                    Console.WriteLine("Dung lượng RAM cao nhất là: {0}\n\n{1}", dl, dsMT);
                    break;
                case Menu.TimRAMDungLuongThapNhat:
                    dl = ds.TimRAMDungLuongMIN();
                    dsMT = ds.TimTatCaMTCoDungLuongRAMMIN();
                    Console.WriteLine("Dung lượng RAM thấp nhất là: {0}\n\n{1}", dl, dsMT);
                    break;
                case Menu.TimCPUGiaThapNhat:
                    gia = ds.TimGiaCPUThapNhat();
                    dsMT = ds.TimTatCaMTCoCPUGiaThapNhat();
                    Console.WriteLine("Gía CPU thấp nhất là: {0}\n\n{1}", gia, dsMT);
                    break;
                case Menu.TimMTCo2CPU:
                    dsMT = ds.TimTatCaMTCo2CPU();
                    Console.WriteLine("Danh sách máy tính có 2 CPU:\n{0}",dsMT);
                    break;
                case Menu.TimHangNhieuLinhKienNhat:
                    listStr = ds.TimHangCoNhieuLinhKienNhat();
                    Console.WriteLine("Hãng có nhiều linh kiện nhất là:");
                    for (int i = 0; i < listStr.Count; i++)
                        Console.WriteLine(listStr[i] + "\n");
                    break;
                case Menu.TimSoLuongLinhKienTheoHang:
                    Console.Write("Nhập hãng cần tìm số lượng linh kiện: ");
                    h = Console.ReadLine();
                    dem = ds.TimSoLinhKienTheoHang(h);
                    Console.WriteLine("Số lượng linh kiện hãng {0} là: {1}",h,dem);
                    break;
                case Menu.DemSoLuongCPU:
                    dem = ds.DemSoLuongCPU();
                    Console.WriteLine("Số lượng CPU: {0}",dem);
                    break;
                case Menu.DemSoLuongRAM:
                    dem = ds.DemSoLuongRAM();
                    Console.WriteLine("Số lượng RAM: {0}", dem);
                    break;
                case Menu.XoaTatCaMTDungLuongRAMX:
                    Console.Write("Nhập dung lượng RAM muốn xóa: ");
                    dl = float.Parse(Console.ReadLine());
                    ds.XoaTatCaMTDungLuongRAMX(dl);
                    Console.WriteLine("Danh sách sau khi xóa\n{0}",ds);
                    break;
                case Menu.SapXepMTTangTheoGia:
                    ds.SapXepTangTheoGia();
                    Console.WriteLine("Danh sách sau khi sắp xếp tăng theo giá\n{0}",ds);
                    break;
                case Menu.SapXepMTGiamTheoGia:
                    ds.SapXepGiamTheoGia();
                    Console.WriteLine("Danh sách sau khi sắp xếp giảm theo giá\n{0}", ds);
                    break;
                case Menu.SapXepMTTangTheoSoLuongCPU:
                    ds.SapXepTangTheoSoLuongCPU();
                    Console.WriteLine("Danh sách sau khi sắp xếp tăng theo số lượng CPU\n{0}",ds);
                    break;
                case Menu.SapXepMTGiamTheoSoLuongCPU:
                    ds.SapXepGiamTheoSoLuongCPU();
                    Console.WriteLine("Danh sách sau khi sắp xếp giảm theo số lượng CPU\n{0}",ds);
                    break;
                case Menu.SapXepMTTangTheoSoLuongRAM:
                    ds.SapXepTangTheoSoLuongRAM();
                    Console.WriteLine("Danh sách sau khi sắp xếp tăng theo số lượng RAM\n{0}",ds);
                    break;
                case Menu.SapXepMTGiamTheoSoLuongRAM:
                    ds.SapXepGiamTheoSoLuongRam();
                    Console.WriteLine("Danh sách sau khi sắp xếp giảm theo số lượng RAM\n{0}", ds);
                    break;
                case Menu.SapXepHangTangTheoSoLuongLinhKien:
                    Console.WriteLine("Danh sách hãng tăng theo số linh kiện: ");
                    ds.SapXepTangTheoSoLuongLinhKien();
                    break;
                case Menu.SapXepHangGiamTheoSoLuongLinhKien:
                    Console.WriteLine("Danh sách hãng giảm theo số linh kiện: ");
                    ds.SapXepGiamTheoSoLuongLinhKien();
                    break;
                case Menu.TimNuocCoSoLuongMainBoardX:
                    Console.Write("Nhập số mainboard x: ");
                    dem = int.Parse(Console.ReadLine());
                    listStr = ds.TimNuocCoSoLuongMainBoardX(dem);
                    if (ds.IsEmptyListStr(listStr))
                        Console.WriteLine("Không có nước nào có số lượng {0} MainBoard",dem);
                    else
                    {
                        for (int i = 0; i < listStr.Count; i++)
                            Console.WriteLine(listStr[i] + "\n");
                    }    
                    break;
                case Menu.TimNuocSanXuatNhieuMainBoardNhat:
                    listStr = ds.TimNuocSXNhieuMainBoardNhat();
                    Console.WriteLine("\nNước sản xuất nhiều MainBoard nhất là: ");
                    for (int i = 0; i < listStr.Count; i++)
                        Console.WriteLine(listStr[i] + "\n");
                    break;
                case Menu.TimTatCaMTSuDungMainBoardX:
                    Console.Write("Nhập nước SX muốn tìm: ");
                    h = Console.ReadLine();
                    dsMT = ds.TimTatCaMTSuDungMainBoardNuocX(h);
                    if(dsMT.IsEmptyCollection())
                        Console.WriteLine("\nKhông có MainBoard được sản xuất tại {0} ",h);
                    else
                        Console.WriteLine("\nDanh sách các máy tính có MainBoard được sx tại {0} là:\n{1}",h,dsMT);
                    break;
                case Menu.TimTatCaMTKhongDungMainBoardX:
                    Console.Write("Nhập nước SX: ");
                    h = Console.ReadLine();
                    dsMT = ds.TimTatCaMTKhongSuDungMainBoardNuocX(h);
                    if (dsMT.IsEmptyCollection())
                        Console.WriteLine("\nKhông có MainBoard nào không sản xuất tại {0} ", h);
                    else
                        Console.WriteLine("\nDanh sách các máy tính có MainBoard không sx tại {0} là:\n{1}", h, dsMT);
                    break;
                case Menu.XoaTatCaMTSuDungMainBoardX:
                    Console.Write("Nhập nước SX: ");
                    h = Console.ReadLine();
                    ds.XoaTatCaMTSuDungMainBoardSXTaiX(h);
                    Console.WriteLine("\nDanh sách sau khi xóa MT có MainBoard sx tại {0} là\n{1}",h,ds);
                    break;
                case Menu.TimViTriMTSuDungMainBoardX:
                    Console.Write("Nhập nước SX: ");
                    h = Console.ReadLine();
                    listInt = ds.TimViTriMTSuDungMainBoardSXTaiX(h);
                    if (ds.IsEmptyListInt(listInt))
                        Console.WriteLine("\nKhông có MainBoard nào sản xuất tại {0} ", h);
                    else
                    {
                        Console.WriteLine("\nVị trí các máy tính có MainBoard sx tại {0} là:\n", h);
                        for(int i = 0; i < listInt.Count; i++)
                            Console.Write(listInt[i]+"\t");
                    }    
                    break;
                case Menu.TimHangCoSoLuongSXMainBoardItNhatTheoNuoc:
                    Console.Write("Nhập nước SX: ");
                    h = Console.ReadLine();
                    listStr = ds.TimHangCoSoMainBoardItNhatTheoNuocSX(h);
                    for (int i = 0; i < listStr.Count; i++)
                        Console.WriteLine(listStr[i] + "\n");
                    break;
                case Menu.TimHangCoSoLuongSXMainBoardNhieuNhatTheoNuoc:
                    Console.Write("Nhập nước SX: ");
                    h = Console.ReadLine();
                    listStr = ds.TimHangCoSoMainBoardNhieuNhatTheoNuocSX(h);
                    if (ds.IsEmptyListStr(listStr))
                        Console.WriteLine("Không có MainBoard dược sx tại {0}",h);
                    else
                    {
                        for (int i = 0; i < listStr.Count; i++)
                            Console.WriteLine(listStr[i] + "\n");
                    }
                    break;
                case Menu.TinhTongGiaMTSuDungMainBoardTheoNuoc:
                    Console.Write("Nhập nước SX: ");
                    h = Console.ReadLine();
                    gia = ds.TinhTongGiaBanMainBoardTheoNuoc(h);
                    Console.Write("Tổng giá máy tính có MainBoard sx tại {0} là: {1}",h,gia);
                    break;
            }    
        }
    }
}
