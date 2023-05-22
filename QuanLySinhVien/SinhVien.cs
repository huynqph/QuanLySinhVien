using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace dsad
{
    class SinhVien
    {

        private List<SinhVien> danhSachSinhVien;

        private static int nextId = 1;
        public int Id { get; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }
        public double DiemCSharp { get; set; }
        public double DiemUnity { get; set; }
        public double Diem3D { get; set; }
        public double DiemTrungBinh { get; set; }
        public string XepLoai { get; set; }

        public SinhVien()
        {
            danhSachSinhVien = new List<SinhVien>();
        }

        public SinhVien(string hoTen, string gioiTinh, int tuoi, double diemCSharp, double diemUnity, double diem3D)
        {
            Id = nextId++;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            Tuoi = tuoi;
            DiemCSharp = diemCSharp;
            DiemUnity = diemUnity;
            Diem3D = diem3D;
            TinhDiemTrungBinh();
            XepLoaiHocLuc();
        }

        private void TinhDiemTrungBinh()
        {
            DiemTrungBinh = (DiemCSharp + DiemUnity + Diem3D) / 3;
        }

        private void XepLoaiHocLuc()
        {
            if (DiemTrungBinh >= 8.5)
            {
                XepLoai = "Giỏi";
            }
            else if (DiemTrungBinh >= 6.5)
            {
                XepLoai = "Khá";
            }
            else if (DiemTrungBinh >= 5)
            {
                XepLoai = "Trung bình";
            }
            else
            {
                XepLoai = "Yếu";
            }
        }

        public void Xuat()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Giới tính: {GioiTinh}");
            Console.WriteLine($"Tuổi: {Tuoi}");
            Console.WriteLine($"Điểm C#: {DiemCSharp}");
            Console.WriteLine($"Điểm Unity: {DiemUnity}");
            Console.WriteLine($"Điểm 3D: {Diem3D}");
            Console.WriteLine($"Điểm trung bình: {DiemTrungBinh}");
            Console.WriteLine($"Xếp loại học lực: {XepLoai}");
            Console.WriteLine();
        }

        public int SoLuongSinhVien()
        {
            return danhSachSinhVien.Count;
        }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();

            Console.Write("Nhập giới tính: ");
            string gioiTinh = Console.ReadLine();

            Console.Write("Nhập tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());

            Console.Write("Nhập điểm C#: ");
            double diemCSharp = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm Unity: ");
            double diemUnity = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm 3D: ");
            double diem3D = double.Parse(Console.ReadLine());

            SinhVien sinhVien = new SinhVien(hoTen, gioiTinh, tuoi, diemCSharp, diemUnity, diem3D);
            danhSachSinhVien.Add(sinhVien);

            Console.WriteLine("Thêm sinh viên thành công!");
        }

        public void CapNhatThongTinSinhVien()
        {
            Console.Write("Nhập ID sinh viên cần cập nhật thông tin: ");
            int id = int.Parse(Console.ReadLine());

            SinhVien sinhVien = danhSachSinhVien.Find(sv => sv.Id == id);
            if (sinhVien != null)
            {
                Console.WriteLine("Nhập thông tin cần cập nhật:");

                Console.Write("Họ tên: ");
                sinhVien.HoTen = Console.ReadLine();

                Console.Write("Giới tính: ");
                sinhVien.GioiTinh = Console.ReadLine();

                Console.Write("Tuổi: ");
                sinhVien.Tuoi = int.Parse(Console.ReadLine());

                Console.Write("Điểm C#: ");
                sinhVien.DiemCSharp = double.Parse(Console.ReadLine());

                Console.Write("Điểm Unity: ");
                sinhVien.DiemUnity = double.Parse(Console.ReadLine());

                Console.Write("Điểm 3D: ");
                sinhVien.Diem3D = double.Parse(Console.ReadLine());

                sinhVien.TinhDiemTrungBinh();
                sinhVien.XepLoaiHocLuc();

                Console.WriteLine("Cập nhật thông tin sinh viên thành công!");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên có ID đã nhập!");
            }
        }

        public void XoaSinhVien()
        {
            Console.Write("Nhập ID sinh viên cần xóa: ");
            int id = int.Parse(Console.ReadLine());

            SinhVien sinhVien = danhSachSinhVien.Find(sv => sv.Id == id);
            if (sinhVien != null)
            {
                danhSachSinhVien.Remove(sinhVien);
                Console.WriteLine("Xóa sinh viên thành công!");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên có ID đã nhập!");
            }
        }

        public void TimKiemSinhVienTheoTen()
        {
            Console.Write("Nhập tên sinh viên cần tìm kiếm: ");
            string ten = Console.ReadLine();

            List<SinhVien> ketQuaTimKiem = danhSachSinhVien.FindAll(sv => sv.HoTen.Contains(ten));
            if (ketQuaTimKiem.Count > 0)
            {
                Console.WriteLine("Kết quả tìm kiếm:");
                foreach (SinhVien sinhVien in ketQuaTimKiem)
                {
                    sinhVien.Xuat();
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên nào có tên đã nhập!");
            }
        }

        public void TimKiemSinhVienTheoID()
        {
            Console.Write("Nhập ID sinh viên cần tìm kiếm: ");
            int id = int.Parse(Console.ReadLine());

            SinhVien sinhVien = danhSachSinhVien.Find(sv => sv.Id == id);
            if (sinhVien != null)
            {
                Console.WriteLine("Kết quả tìm kiếm:");
                sinhVien.Xuat();
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên có ID đã nhập!");
            }
        }

        public void SapXepSinhVienTheoDiemTrungBinh()
        {
            danhSachSinhVien.Sort((sv1, sv2) => sv2.DiemTrungBinh.CompareTo(sv1.DiemTrungBinh));
            Console.WriteLine("Danh sách sinh viên sau khi sắp xếp theo điểm trung bình:");
            HienThiDanhSachSinhVien();
        }

        public void SapXepSinhVienTheoTen()
        {
            danhSachSinhVien.Sort((sv1, sv2) => sv1.HoTen.CompareTo(sv2.HoTen));
            Console.WriteLine("Danh sách sinh viên sau khi sắp xếp theo tên:");
            HienThiDanhSachSinhVien();
        }

        public void SapXepSinhVienTheoID()
        {
            danhSachSinhVien.Sort((sv1, sv2) => sv1.Id.CompareTo(sv2.Id));
            Console.WriteLine("Danh sách sinh viên sau khi sắp xếp theo ID:");
            HienThiDanhSachSinhVien();
        }

        public void HienThiDanhSachSinhVien()
        {
            if (danhSachSinhVien.Count > 0)
            {
                foreach (SinhVien sinhVien in danhSachSinhVien)
                {
                    sinhVien.Xuat();
                }
            }
            else
            {
                Console.WriteLine("Danh sách sinh viên trống!");
            }
        }
    }
}
