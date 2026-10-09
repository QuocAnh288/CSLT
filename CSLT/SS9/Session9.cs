using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT.CSDL.SS9
{
    class Session9
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

        }
        static void Bai1_TaoFileRong(string duongDan)
        {
            File.Create(duongDan).Close();
            Console.WriteLine($"[Bài 1] Đã tạo file rỗng: {duongDan}");
        }

        // 2. Xóa file khỏi ổ đĩa
        static void Bai2_XoaFile(string duongDan)
        {
            if (File.Exists(duongDan))
            {
                File.Delete(duongDan);
                Console.WriteLine($"[Bài 2] Đã xóa file: {duongDan}");
            }
            else
            {
                Console.WriteLine($"[Bài 2] Không tìm thấy file để xóa: {duongDan}");
            }
        }

        // 3. Tạo file và thêm chữ vào
        static void Bai3_TaoFileVaGhiChu(string duongDan, string noiDung)
        {
            File.WriteAllText(duongDan, noiDung, Encoding.UTF8);
            Console.WriteLine($"[Bài 3] Đã tạo file và ghi chữ vào: {duongDan}");
        }

        // 4. Đọc file văn bản
        static void Bai4_DocFile(string duongDan)
        {
            if (File.Exists(duongDan))
            {
                string noiDung = File.ReadAllText(duongDan, Encoding.UTF8);
                Console.WriteLine(noiDung);
            }
            else
            {
                Console.WriteLine("File không tồn tại!");
            }
        }

        // 5. Ghi một mảng chuỗi vào file
        static void Bai5_GhiMangChuoi(string duongDan, string[] mangChuoi)
        {
            File.WriteAllLines(duongDan, mangChuoi, Encoding.UTF8);
            Console.WriteLine($"[Bài 5] Đã ghi mảng chuỗi vào file: {duongDan}");
        }

        // 6. Ghi nối tiếp văn bản vào file đã có
        static void Bai6_GhiNoiTiep(string duongDan, string noiDungThem)
        {
            File.AppendAllText(duongDan, Environment.NewLine + noiDungThem, Encoding.UTF8);
            Console.WriteLine($"[Bài 6] Đã thêm văn bản vào file: {duongDan}");
        }

        // 7. Tạo bản sao file sang tên khác và in nội dung
        static void Bai7_CopyFileVaIn(string fileGoc, string fileCopy)
        {
            File.Copy(fileGoc, fileCopy, true);
            Console.WriteLine($"\n[Bài 7] Đã copy từ {fileGoc} sang {fileCopy}. Nội dung file copy:");
            string noiDung = File.ReadAllText(fileCopy, Encoding.UTF8);
            Console.WriteLine(noiDung);
        }

        // 8. Đổi tên file (Move trong cùng thư mục)
        static void Bai8_DoiTenFile(string tenCu, string tenMoi)
        {
            if (File.Exists(tenMoi))
            {
                File.Delete(tenMoi);
            }
            File.Move(tenCu, tenMoi);
            Console.WriteLine($"[Bài 8] Đã đổi tên file {tenCu} thành {tenMoi}");
        }

        // 9. Đọc dòng đầu tiên của file
        static void Bai9_DocDongDau(string duongDan)
        {
            if (!File.Exists(duongDan)) return;

            using (StreamReader doc = new StreamReader(duongDan, Encoding.UTF8))
            {
                string dongDau = doc.ReadLine();
                Console.WriteLine(dongDau);
            }
        }

        // 10. Đọc dòng cuối cùng của file
        static void Bai10_DocDongCuoi(string duongDan)
        {
            if (!File.Exists(duongDan)) return;

            string[] cacDong = File.ReadAllLines(duongDan, Encoding.UTF8);
            if (cacDong.Length > 0)
            {
                Console.WriteLine(cacDong[cacDong.Length - 1]);
            }
            else
            {
                Console.WriteLine("File rỗng!");
            }
        }

        // 11. Đọc n dòng cuối của file
        static void Bai11_DocNDongCuoi(string duongDan, int soDongCanDoc)
        {
            if (!File.Exists(duongDan)) return;

            string[] cacDong = File.ReadAllLines(duongDan, Encoding.UTF8);
            int tongSoDong = cacDong.Length;

       
            int viTriBatDau = tongSoDong - soDongCanDoc;
            if (viTriBatDau < 0) viTriBatDau = 0;

            for (int i = viTriBatDau; i < tongSoDong; i++)
            {
                Console.WriteLine(cacDong[i]);
            }
        }

        // 12. Đọc dòng cụ thể (vị trí tính từ 1)
        static void Bai12_DocDongCuThe(string duongDan, int soDong)
        {
            if (!File.Exists(duongDan)) return;

            string[] cacDong = File.ReadAllLines(duongDan, Encoding.UTF8);
            int viTri = soDong - 1; 

            if (viTri >= 0 && viTri < cacDong.Length)
            {
                Console.WriteLine($"Dòng {soDong}: {cacDong[viTri]}");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy dòng {soDong}!");
            }
        }

        // 13. Đếm số dòng trong file
        static int Bai13_DemSoDong(string duongDan)
        {
            if (!File.Exists(duongDan)) return 0;

            string[] cacDong = File.ReadAllLines(duongDan);
            return cacDong.Length;
        }

        // 14. In cấu trúc thư mục (đệ quy đơn giản)
        static void Bai14_InCauTrucThuMuc(string duongDanThuMuc, string khoangTrang)
        {
            DirectoryInfo thuMuc = new DirectoryInfo(duongDanThuMuc);
            Console.WriteLine($"{khoangTrang}[Thư mục] {thuMuc.Name}");

            // In các file trong thư mục
            FileInfo[] danhSachFile = thuMuc.GetFiles();
            foreach (FileInfo f in danhSachFile)
            {
                Console.WriteLine($"{khoangTrang}   |-- {f.Name}");
            }

            // Đệ quy in các thư mục con
            DirectoryInfo[] danhSachThuMucCon = thuMuc.GetDirectories();
            foreach (DirectoryInfo subDir in danhSachThuMucCon)
            {
                Bai14_InCauTrucThuMuc(subDir.FullName, khoangTrang + "   ");
            }
        }

        // 15. Thống kê ký tự/số bằng mảng chữ nhật và lưu vị trí (dòng, cột) bằng mảng jagged
        static void Bai15_ThongKeKyTuVaViTri(string duongDan)
        {
            if (!File.Exists(duongDan)) return;

            string[] cacDong = File.ReadAllLines(duongDan, Encoding.UTF8);

            
            int[,] mangChuNhat = new int[128, 2];
            for (int i = 0; i < 128; i++)
            {
                mangChuNhat[i, 0] = i; 
                mangChuNhat[i, 1] = 0; 
            }

          
            for (int i = 0; i < cacDong.Length; i++)
            {
                for (int j = 0; j < cacDong[i].Length; j++)
                {
                    char kyTu = cacDong[i][j];
                
                    if (char.IsLetterOrDigit(kyTu) && (int)kyTu < 128)
                    {
                        mangChuNhat[(int)kyTu, 1]++;
                    }
                }
            }

           
            string[][] mangJagged = new string[128][];
            for (int i = 0; i < 128; i++)
            {
                int soLan = mangChuNhat[i, 1];
                mangJagged[i] = new string[soLan]; 
            }

           
            int[] chiSoHienTai = new int[128];

            for (int i = 0; i < cacDong.Length; i++)
            {
                for (int j = 0; j < cacDong[i].Length; j++)
                {
                    char kyTu = cacDong[i][j];
                    if (char.IsLetterOrDigit(kyTu) && (int)kyTu < 128)
                    {
                        int maAscii = (int)kyTu;
                        int viTri = chiSoHienTai[maAscii];
                     
                        mangJagged[maAscii][viTri] = $"({i + 1},{j + 1})";
                        chiSoHienTai[maAscii]++;
                    }
                }
            }

            // In kết quả
            Console.WriteLine("{0,-8} | {1,-10} | {2}", "Ký tự", "Số lần", "Các vị trí (dòng, cột)");
            Console.WriteLine(new string('-', 55));

            for (int i = 0; i < 128; i++)
            {
                int soLan = mangChuNhat[i, 1];
                if (soLan > 0)
                {
                    char kyTu = (char)mangChuNhat[i, 0];
                    string chuoiViTri = string.Join(", ", mangJagged[i]);
                    Console.WriteLine("{0,-8} | {1,-10} | {2}", $"'{kyTu}'", soLan, chuoiViTri);
                }
            }
        }

    }
}
