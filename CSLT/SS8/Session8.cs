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

namespace CSLT.CSDL.SS5
{
    class Session8
    {
        static void Main5(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

           
        }
        static string Cau1_NhapVaInChuoi()
        {
            Console.Write("[1] Nhập vào một chuỗi: ");
            string s = Console.ReadLine() ?? "";
            Console.WriteLine($"Chuỗi vừa nhập là: \"{s}\"");
            return s;
        }

        // 2. Độ dài chuỗi không dùng hàm thư viện (.Length)
        static int Cau2_TinhDoDai(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                count++;
            }
            return count;
        }

        // 3. Tách các ký tự riêng lẻ
        static void Cau3_TachKyTu(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write($"{s[i]} ");
            }
        }

        // 4. In các ký tự theo thứ tự đảo ngược
        static void Cau4_InDaoNguoc(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }

        // 5. Đếm tổng số từ trong chuỗi
        static int Cau5_DemSoTu(string s)
        {
            int wordCount = 0;
            bool inWord = false;
            int len = s.Length;

            for (int i = 0; i < len; i++)
            {
                if (s[i] != ' ')
                {
                    if (!inWord)
                    {
                        wordCount++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
            }
            return wordCount;
        }

        // 6. So sánh 2 chuỗi
        static int Cau6_SoSanhChuoi(string s1, string s2)
        {
            int len1 = Cau2_TinhDoDai(s1);
            int len2 = Cau2_TinhDoDai(s2);
            int minLen = len1 < len2 ? len1 : len2;

            for (int i = 0; i < minLen; i++)
            {
                if (s1[i] != s2[i])
                {
                    return s1[i] - s2[i];
                }
            }
            return len1 - len2;
        }

        // 7. Đếm số chữ cái, chữ số và ký tự đặc biệt
        static void Cau7_DemLoaiKyTu(string s, out int chu, out int so, out int specials)
        {
            chu = 0;
            so = 0;
            specials = 0;
            int len = Cau2_TinhDoDai(s);

            for (int i = 0; i < len; i++)
            {
                char c = s[i];
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    chu++;
                else if (c >= '0' && c <= '9')
                    so++;
                else
                    specials++;
            }
        }

        // 8. Đếm số nguyên âm và phụ âm (chỉ tính trên ký tự chữ cái)
        static void Cau8_DemNguyenAmPhuAm(string s, out int nguyenAm, out int phuAm)
        {
            nguyenAm = 0;
            phuAm = 0;
            int len = s.Length;

            for (int i = 0; i < len; i++)
            {
                char c = s[i];
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    char lower = (c >= 'A' && c <= 'Z') ? (char)(c + 32) : c;
                    if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                        nguyenAm++;
                    else
                        phuAm++;
                }
            }
        }

        // 10. Tìm vị trí xuất hiện đầu tiên của chuỗi con (hàm nền tảng cho câu 9, 12, 13)
        static int Cau10_TimViTriChuoiCon(string str, string sub)
        {
            int lenStr = Cau2_TinhDoDai(str);
            int lenSub = Cau2_TinhDoDai(sub);

            if (lenSub == 0) return 0;
            if (lenSub > lenStr) return -1;

            for (int i = 0; i <= lenStr - lenSub; i++)
            {
                int j;
                for (j = 0; j < lenSub; j++)
                {
                    if (str[i + j] != sub[j])
                        break;
                }
                if (j == lenSub)
                    return i;
            }
            return -1;
        }
        // 11. Kiểm tra ký tự có phải là chữ cái và xét chữ hoa/thường
        static void Cau11_KiemTraKyTu(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine($"Ký tự '{c}' là chữ cái (Chữ thường).");
            }
            else if (c >= 'A' && c <= 'Z')
            {
                Console.WriteLine($"Ký tự '{c}' là chữ cái (Chữ hoa).");
            }
            else
            {
                Console.WriteLine($"Ký tự '{c}' không phải là chữ cái.");
            }
        }

        // 12. Đếm số lần xuất hiện của chuỗi con
        static int Cau12_DemSoLanXuatHien(string str, string sub)
        {
            int lenStr = Cau2_TinhDoDai(str);
            int lenSub = Cau2_TinhDoDai(sub);

            if (lenSub == 0 || lenSub > lenStr) return 0;

            int count = 0;
            for (int i = 0; i <= lenStr - lenSub; i++)
            {
                int j;
                for (j = 0; j < lenSub; j++)
                {
                    if (str[i + j] != sub[j])
                        break;
                }
                if (j == lenSub)
                {
                    count++;
                    i += lenSub - 1;  
                }
            }
            return count;
        }

        // 13. Chèn chuỗi con vào trước lần xuất hiện đầu tiên của một chuỗi
        static string Cau13_ChenChuoiCon(string source, string target, string toInsert)
        {
            int pos = Cau10_TimViTriChuoiCon(source, target);
            if (pos == -1)
            {
                Console.WriteLine($"Không tìm thấy chuỗi \"{target}\" trong chuỗi nguồn.");
                return source;
            }

            int lenSource = Cau2_TinhDoDai(source);
            int lenInsert = Cau2_TinhDoDai(toInsert);
            char[] result = new char[lenSource + lenInsert];

            int index = 0;
           
            for (int i = 0; i < pos; i++)
                result[index++] = source[i];

            for (int i = 0; i < lenInsert; i++)
                result[index++] = toInsert[i];

            for (int i = pos; i < lenSource; i++)
                result[index++] = source[i];

            return new string(result);
        }
    }
}
