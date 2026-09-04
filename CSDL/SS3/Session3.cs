using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT.SS3
{
    class Session3
    {
        enum CurrencyType
        {
            USD = 1, EUR, JPY, GBP
        }
        enum CustomerType
        {
            Child, Student, Adult, Senior
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            {//exercise1();
             //exercise2(); 
             //exercise3(); 
             //bt1();
             //bt2();
             //bt3();
             //bt5();
             //bt7();
             //bt9();
             //bt11();
                bt15();
            }

            static void exercise1()
            {
                // Convert Celsius to Fahrenheit and Kelvin
                Console.WriteLine("Enter temperature in Celsius:");
                double c = double.Parse(Console.ReadLine());
                double fahrenheit = (c * 9 / 5) + 32;
                double kelvin = c + 273.15;

                Console.WriteLine($"{c} Celsius = {fahrenheit} Fahrenheit");
                Console.WriteLine($"{c} Celsius = {kelvin} Kelvin");
            }
            static void exercise2()
            {
                // surface and volume of a sphere
                Console.WriteLine("Enter radius of the sphere:");
                double r = double.Parse(Console.ReadLine());
                double surfaceArea = 4 * Math.PI * r * r;
                double volume = (4 / 3) * Math.PI * r * r * r;
                Console.WriteLine($"Surface area of the sphere = {surfaceArea}");
                Console.WriteLine($"Volume of the sphere = {volume}");
            }
            static void exercise3()
            {
                // calculates the result of adding, subtracting, multiplying, and dividing two numbers
                Console.WriteLine("Enter a:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter b:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a} + {b} = {a + b}");
                Console.WriteLine($"{a} - {b} = {a - b}");
                Console.WriteLine($"{a} * {b} = {a * b}");
                Console.WriteLine($"{a} / {b} = {a / b}");
                Console.WriteLine($"{a} % {b} = {a % b}");
            }
            static void bt1()
            {
                // Bài tập 1
                Console.WriteLine($"Nhập số điện cũ:");
                long SDC = long.Parse(Console.ReadLine());
                long SDM;

                do
                {
                    Console.WriteLine($"Nhập số điện mới:");
                    SDM = long.Parse(Console.ReadLine());

                    if (SDM >= SDC)
                        break;
                    else
                        Console.WriteLine($"Số điện mới phải lớn hơn số điện cũ!");
                } while (true);

                long Dien = SDM - SDC;
                Console.WriteLine($"Lượng điện tiêu thụ trong tháng: {Dien}");
                decimal TienDien = 0;
                if (Dien <= 50)
                {
                    TienDien = Dien * 1806;
                    Console.WriteLine($"Tiền điện chưa thuế:{TienDien} VND");
                }
                else if (Dien <= 100)
                {
                    TienDien = 50 * 1806 + (Dien - 50) * 1866;
                    Console.WriteLine($"Tiền điện chưa thuế: {TienDien} VND");
                }
                else if (Dien <= 200)
                {
                    TienDien = 50 * 1806 + 50 * 1866 + (Dien - 100) * 2167;
                    Console.WriteLine($"Tiền điện chưa thuế: {TienDien} VND");
                }
                else if (Dien <= 300)
                {
                    TienDien = 50 * 1806 + 50 * 1866 + 100 * 2167 + (Dien - 200) * 2729;
                    Console.WriteLine($"Tiền điện chưa thuế: {TienDien} VND");
                }
                else
                {
                    TienDien = 50 * 1806 + 50 * 1866 + 100 * 2167 + 100 * 2729 + (Dien - 300) * 3050;
                    Console.WriteLine($"Tiền điện chưa thuế: {TienDien} VND");
                }
                decimal vat = TienDien * 0.08m;

                Console.WriteLine($"Tiền VAT: {vat} VND");
                Console.WriteLine($"Tiền điện thanh toán : {TienDien + vat} VND");

            }
            static void bt2()
            {
                //bai tap 2
                Console.WriteLine("Nhập cân nặng:");
                double weight = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập chiều cao:");
                double height = double.Parse(Console.ReadLine());
                double BMI = weight / (height * height);
                double Min = 18.5 * height * height;
                double Max = 22.9 * height * height;
                if (BMI < 18.5)
                {
                    Console.WriteLine("Thiếu cân");
                }
                else if (BMI < 23)
                {
                    Console.WriteLine("Bình thường (Lý tưởng)");
                }
                else if (BMI < 25)
                {
                    Console.WriteLine("Thừa cân.");
                }
                else
                {
                    Console.WriteLine("Béo phì");
                }
                Console.WriteLine(string.Format("Chỉ số BMI: {0:F2}", BMI));
                Console.WriteLine(string.Format("Dải cân nặng lí tưởng: {0:F2} - {1:F2}", Min, Max));

            }
            static void bt3()
            {
                Console.WriteLine("Nhập số tiền cần đổi ngoại tệ (VNĐ)");
                decimal VND = decimal.Parse(Console.ReadLine());
                decimal PHI = (VND) * 0.005m;
                decimal VNDR = VND - PHI;
                Console.WriteLine("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP)");
                if (!int.TryParse(Console.ReadLine(), out int choice) || !Enum.IsDefined(typeof(CurrencyType), choice))
                {
                    Console.WriteLine("Lựa chọn ngoại tệ không hợp lệ!");
                    return;
                }

                CurrencyType selectedCurrency = (CurrencyType)choice;
                decimal TyGia = 0m;
                string DV = "";
                switch (selectedCurrency)
                {
                    case CurrencyType.USD:
                        TyGia = 25400m;
                        DV = "Dola";
                        break;

                    case CurrencyType.EUR:
                        TyGia = 27200m;
                        DV = "Euro";
                        break;

                    case CurrencyType.JPY:
                        TyGia = 165m;
                        DV = "Yen";
                        break;

                    case CurrencyType.GBP:
                        TyGia = 32100m;
                        DV = "GBP";
                        break;
                }
                Console.WriteLine($"Tiền phí chuyển đổi:{PHI:N2}");
                Console.WriteLine($"Số tiền sau khi trừ phí:{VNDR:N2}");
                Console.WriteLine($"{VNDR:N0}(VNĐ) = {(VNDR / TyGia):N2}({DV}) ");



            }
            static void bt5()
            {
                Console.WriteLine("Nhập số tín C#");
                int TLT = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập số tín TA");
                int TTA = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập số tín T");
                int TT = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập số điểm C#");
                double DLT = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập số điểm TA");
                double DTA = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập số điểm T");
                double DT = double.Parse(Console.ReadLine());
                double AVG_D = (TLT * DLT + TTA * DTA + DT * TT) / (TLT + TTA + TT);
                if (AVG_D >= 8.5)
                {
                    Console.WriteLine($"Điểm của bạn là:{AVG_D:N2}");
                    Console.WriteLine($"Điểm thang 4 là: 4.0");
                    Console.WriteLine("Xếp loại: Xuất sắc");


                }
                else if (AVG_D >= 7)
                {
                    Console.WriteLine($"Điểm của bạn là:{AVG_D:N2}");
                    Console.WriteLine($"Điểm thang 4 là: 3.0");
                    Console.WriteLine("Xếp loại: Khá");
                }
                else if (AVG_D >= 5.5)
                {
                    Console.WriteLine($"Điểm của bạn là:{AVG_D:N2}");
                    Console.WriteLine($"Điểm thang 4 là: 2.0");
                    Console.WriteLine("Xếp loại: Trung Bình");
                }
                else if (AVG_D >= 4)
                {
                    Console.WriteLine($"Điểm của bạn là:{AVG_D:N2}");
                    Console.WriteLine($"Điểm thang 4 là: 1.0");
                    Console.WriteLine("Xếp loại: Yếu");
                }
                else
                {
                    Console.WriteLine($"Điểm của bạn là:{AVG_D:N2}");
                    Console.WriteLine($"Điểm thang 4 là: 0");
                    Console.WriteLine("Xếp loại: Kém");
                }

            }
            static void bt7()
            {
                Console.WriteLine("Nhập khoảng cách chuyến đi");
                double km = double.Parse(Console.ReadLine());
                Console.WriteLine("Mức tiêu thụ nhiên liệu trung bình của xe(lít/ 100km)");
                double A_L = double.Parse(Console.ReadLine());
                Console.WriteLine("Giá xăng hiện tại");
                decimal Cost = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Số người tham gia chuyến đi");
                int Mem = int.Parse(Console.ReadLine());
                double L = (km / 100) * A_L;
                decimal Tong = (decimal)L * Cost;
                decimal Chia = Tong / (decimal)Mem;
                Console.WriteLine($"Số xăng sử dụng:{L}lít");
                Console.WriteLine($"Chi phí tiền xăng là:{Tong}");
                Console.WriteLine($"Mỗi người phải trả là:{Math.Ceiling(Chia):N2}");

            }
            static void bt9()
            {

                Console.WriteLine("Nhập lương Gross(VNĐ):");
                decimal Gross = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Nhập số người phụ thuộc:");
                int Dependents = int.Parse(Console.ReadLine());
                decimal totalTax = Gross * (10.5m / 100m);
                decimal TaxableIncome = Gross - totalTax - 11000000 - (4400000 * Dependents);
                if (TaxableIncome <= 0)
                {
                    TaxableIncome = 0;
                }
                (decimal Limit, decimal Rate)[] branket = [
                    (5_000_000m, 0.05m),
                    (10_000_000m, 0.10m),
                    (18_000_000m, 0.15m),
                    (32_000_000m, 0.20m),
                    (52_000_000m, 0.25m),
                    (80_000_000m, 0.30m),
                    (decimal.MaxValue,0.35m)];
                decimal tax = 0, Prelimit = 0;
                foreach (var (Limit, Rate) in branket)
                {
                    if (TaxableIncome <= Prelimit) break;

                    tax += (Math.Min(TaxableIncome, Limit) - Prelimit) * Rate;

                    Prelimit = Limit;
                }
                decimal net = Gross - totalTax - tax;

                Console.WriteLine($"\nBảo hiểm (10.5%):     {totalTax:N0} VNĐ");
                Console.WriteLine($"Thu nhập tính thuế:   {TaxableIncome:N0} VNĐ");
                Console.WriteLine($"Thuế TNCN:            {tax:N0} VNĐ");
                Console.WriteLine($"=> LƯƠNG NET:         {net:N0} VNĐ");
            }
            static void bt11()
            {
                Console.WriteLine("Nhập số tiền gửi ngân hàng:");
                decimal P = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Nhập thời gian gửi:");
                int Thang = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập lãi suất mỗi năm");
                double r = double.Parse(Console.ReadLine());
                decimal LaiDon = P * ((decimal)r / 100m) * ((decimal)Thang / 12m);
                decimal LaiKep = P * (decimal)Math.Pow((r / 100 / 12) + 1, Thang) - P;
                decimal Check = LaiKep - LaiDon;
                Console.WriteLine($"Lãi đơn: {LaiDon:N0}");
                Console.WriteLine($"Lãi kép: {LaiKep:N0}");
                Console.WriteLine($"Chênh lệch: {Check:N0}(Lãi kép tối ưu hơn lãi đơn)");

            }
            static void bt15()
            {
                const decimal BasePrice = 100000m; // Giá vé gốc tiêu chuẩn: 100.000 VNĐ
                const decimal WeekendSurchargeAmount = 20000m; // Phụ thu cuối tuần
                Console.WriteLine("\nChọn loại khách hàng (0: Child, 1: Student, 2: Adult, 3: Senior):");
                CustomerType customer = (CustomerType)int.Parse(Console.ReadLine());
                Console.WriteLine("Chọn một ngày trong tuần(0: Sunday, 1: Monday, 2: Tuesday, 3: Wednesday, 4: Thursday, 5: Friday, 6: Saturday):");
                DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
                bool HasStudentcard = false;
                if(customer == CustomerType.Student)
                {
                    Console.WriteLine("Có thẻ sinh viên hợp lệ(True/False)");
                    HasStudentcard = bool.Parse(Console.ReadLine());
                }    
                decimal DiscountRate = 0;
                if (customer == CustomerType.Child || customer == CustomerType.Senior)
                {
                    DiscountRate = 0.5m;
                }
                else if (customer == CustomerType.Student && HasStudentcard == true)
                {
                    if (day >= DayOfWeek.Monday && day <= DayOfWeek.Thursday)
                    {
                        DiscountRate = 0.3m;
                    }
                    
                }
                else if(day == DayOfWeek.Wednesday && customer == CustomerType.Adult)
                {
                    DiscountRate = 0.2m;
                }
                decimal phuthu = 0;
                if(day == DayOfWeek.Friday || day == DayOfWeek.Saturday || day == DayOfWeek.Sunday )
                {
                    phuthu = WeekendSurchargeAmount;
                }
                decimal final = (BasePrice - DiscountRate * BasePrice) + phuthu;
                Console.WriteLine("\n========================================");
                Console.WriteLine("            VÉ XEM PHIM CHI TIẾT        ");
                Console.WriteLine("========================================");
                Console.WriteLine($"Khách hàng        : {customer}");
                if(customer == CustomerType.Student && HasStudentcard == true)
                {
                    Console.WriteLine($"Thẻ sinh viên hợp lệ" );
                }
                else if (customer == CustomerType.Student && HasStudentcard == false)
                    Console.WriteLine($"Thẻ sinh viên không hợp lệ");

                Console.WriteLine($"Ngày xem          : {day}");
                Console.WriteLine($"Giá vé cơ bản:{BasePrice}(VNĐ)");
                Console.WriteLine($"Giảm giá:{(DiscountRate * BasePrice):N0}(VNĐ)");
                Console.WriteLine($"Phụ thu cuối tuần:{phuthu:N0}(VNĐ)");
                Console.WriteLine($"Tiền vé cuối cùng:{final:N0}(VNĐ)");
                





            }
        }
    }
}
