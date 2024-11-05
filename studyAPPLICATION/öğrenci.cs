using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyAPPLICATION
{
   public class öğrenci
    {

        private int öğrencino;
        private String isim;
        private String soyİsim;
        private int vize1;
        private int vize2;
        private int final;
        private String okulİsmi;

        public öğrenci(int _öğrencino, String _isim, String _soyisim, int _vize1, int _vize2, int _final, String _okulisim)
        {
            öğrencino = _öğrencino;
            isim = _isim;
            soyİsim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulİsmi = _okulisim;
        }
            public void bilgileriGöster()
        {
            Console.WriteLine("öğrencinin ismi :" +isim );
            Console.WriteLine("öğrencinin soyismi :" + soyİsim);
            Console.WriteLine("öğrencinin numarası :" + öğrencino);
            Console.WriteLine("öğrencinin vize1 notu :" + vize1);
            Console.WriteLine("öğrencinin vize2 notu :" + vize2);
            Console.WriteLine("öğrencinin final notu :" + final);

        }
        public double dersOrtlaması()
        {
            double hesap = (vize1 * 0.2 + vize2 * 0.2 + final * 0.8);
            return hesap;

        }
        public void okulİsmim()
        {
            Console.WriteLine("öğrencinin okulunun ismi :"+ okulİsmi);
        }

























    }
}
