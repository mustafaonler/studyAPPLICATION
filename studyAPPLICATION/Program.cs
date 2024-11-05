using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyAPPLICATION
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine( "öğrenci numaranızı giriniz :" );
            int öğrencino = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("isminizi giriniz :");
            String isim1 = Console.ReadLine();
            Console.WriteLine("soy isminizi giriniz :");
            String soyisim = Console.ReadLine();
            Console.WriteLine("vize 1 notunuzu giriniz :");
            int vize11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vize 2 notunuzu giriniz :");
            int vize22 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("final notunuzu giriniz :");
            int final1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("okul isminizi giriniz :");
            String okulgiris = Console.ReadLine();



            Boolean değer = true;
            Console.WriteLine("ÖĞRENCİ BİLGİ SİSTEMİNE HOŞ GELDİNİZ");
            öğrenci öğrenci1 = new öğrenci(öğrencino,isim1,soyisim,vize11,vize22,final1,okulgiris);

            while (değer)
            {


                Console.WriteLine("*************************");
                seçenek();
                Console.WriteLine("*************************");



                Console.WriteLine("seçmek istediğiniz bölümü giriniz");
                String seçim = Console.ReadLine();
                switch (seçim)
                {
                    case "1":
                        öğrenci1.bilgileriGöster();
                        break;


                    case "2":
                        double hesap = öğrenci1.dersOrtlaması();
                        Console.WriteLine("öğrenci not ortalaması :"+hesap);
                        break;


                    case "3":
                        öğrenci1.okulİsmim();
                        break;

                    case "4":
                        Console.WriteLine( "çıkış yapılıyor..." );
                        değer = false;
                        break;


                    default:
                        Console.WriteLine(" lütfen geçerli bir sayı giriniz");
                        break;

                }





            }
             void seçenek()
            {
                Console.WriteLine("1 numara için öğrenci bilgi gösterimi");
                Console.WriteLine("2 numara için öğrenci not ortalaması");
                Console.WriteLine("3 numara için öğrencinin okuduğu okul");
                Console.WriteLine("4 numara için bilgi sisteminden çıkış yapılacaktır");
            }










        }
    }
}
