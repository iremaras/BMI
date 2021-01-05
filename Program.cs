using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            // İrem Aras
            Console.WriteLine("Hoş geldiniz! Vücut kitle indeksiniz hesaplanacak.");
            Console.WriteLine("Lütfen kilonuzu giriniz (kg): ");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen boyunuzu giriniz (m): ");
            double boy = Convert.ToDouble(Console.ReadLine());

            double BMI = kilo / (boy * boy);
            Console.WriteLine($"Vücut kitle indeksiniz = {BMI}");

            if(BMI <= 18.4)
            {
                Console.WriteLine("Zayıf. Boyunuza oranla kilonuz yetersizdir. Diyetisyen eşliğinde sağlılık kilo almanız önerilir.");
            }
            else if(BMI <= 24.9 && BMI >= 18.5)
            {
                Console.WriteLine("Normal. İdeal kilodasınız, dengeli beslenmeye ve spor yapmaya devam edin.");
            }
            else if(BMI <= 29.9 && BMI >= 25)
            {
                Console.WriteLine("Fazla kilolu. Uygun diyet ile fazla kilolarınızdan kurtulmanız önerilir.");
            }
            else if (BMI <= 34.9 && BMI >= 30)
            {
                Console.WriteLine("Şişman. Birinci derece obez kategorisi olarak adlandırılır, kilonuz sağlık açısından risk oluşturabilir.");
            }
            else if (BMI <= 44.9 && BMI >= 35)
            {
                Console.WriteLine("Şişman. İkinci derece obez kategorisi olarak adlandırılır, kilonuz kalp ve damar hastalıkları açısından risk oluşturabilir.");
            }
            else if (BMI >= 45)
            {
                Console.WriteLine("Aşırı şişman. Üçüncü derece obez kategorisi olarak adlandırılır, kilonuz hastalık geliştirme açısından çok risklidir.");
            }


            Console.ReadLine();
        }
    }
}
