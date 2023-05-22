using dsad;
using QuanLySinhvien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class quanLySinhVien
    {
        public void Menu()
        {

            SinhVien SV = new SinhVien();
            int n = 1;
            while (n != 9)
            {
                Console.WriteLine("-----------------------------------MENU-----------------------------------");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Cập nhật thông tin sinh viên bởi ID");
                Console.WriteLine("3. Xóa sinh viên bởi ID");
                Console.WriteLine("4. Tìm kiếm sinh viên theo tên");
                Console.WriteLine("5. Tìm kiếm sinh viên theo ID");
                Console.WriteLine("6. Sắp xếp sinh viên theo điểm trung bình");
                Console.WriteLine("7. Sắp xếp sinh viên theo tên");
                Console.WriteLine("8. Sắp xếp sinh viên theo ID");
                Console.WriteLine("9. Hiển thị danh sách sinh viên");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.Write("Mời bạn chọn chức năng: ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Bạn đã chọn chức năng 1!");
                        Console.WriteLine("*******");
                        SV.Nhap();
                        break;
                    case 2:
                        Console.WriteLine("Bạn đã chọn chức năng 2!");
                        Console.WriteLine("*******");
                        SV.CapNhatThongTinSinhVien();
                        break;
                    case 3:
                        Console.WriteLine("Bạn đã chọn chức năng 3!");
                        Console.WriteLine("*******");
                        SV.XoaSinhVien();
                        break;
                    case 4:
                        Console.WriteLine("Bạn đã chọn chức năng 4!");
                        Console.WriteLine("*******");
                        SV.TimKiemSinhVienTheoTen();
                        break;
                    case 5:
                        Console.WriteLine("Bạn đã chọn chức năng 5!");
                        Console.WriteLine("*******");
                        SV.TimKiemSinhVienTheoID();
                        break;
                    case 6:
                        Console.WriteLine("Bạn đã chọn chức năng 6!");
                        Console.WriteLine("*******");
                        SV.SapXepSinhVienTheoDiemTrungBinh();
                        break;
                    case 7:
                        Console.WriteLine("Bạn đã chọn chức năng 7!");
                        Console.WriteLine("*******");
                        SV.SapXepSinhVienTheoTen();
                        break;
                    case 8:
                        Console.WriteLine("Bạn đã chọn chức năng 8!");
                        Console.WriteLine("*******");
                        SV.SapXepSinhVienTheoID();

                        break;
                    case 9:
                        Console.WriteLine("Bạn đã chọn chức năng 9!");
                        Console.WriteLine("*******");
                        SV.HienThiDanhSachSinhVien();
                        break;
                    default:
                        Console.WriteLine("Bạn đã chọn sai chức năng mời bạn chọn lại!");
                        break;
                }
            }

        }
    }
}
