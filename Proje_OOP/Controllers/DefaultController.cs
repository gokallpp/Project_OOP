using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Ornekler;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void işlemler()
        //{
        //    Class1 c = new Class1();
        //    c.Topla();
        //}

        void mesajlar()
        {
            ViewBag.m1 = "bu bir core oop projesi";
            ViewBag.m2 = "proje mimarisi";
            ViewBag.m3 = "asp.net mvc";
        }

        int Topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;

            return sonuc;
        }



        int Cevre()
        {
            int kisa = 10;
            int uzun = 20;
            int sonuc = 2 * (kisa + uzun);

            return sonuc;
        }


        string cumle()
        {
            string c = "Uygulamalı Proje Üzerinde OOP (Object Oriented Programming)";

            return c;
        }

        void MesajListesi(string p)  //metotlarda parametreli kullanım
        {
            ViewBag.v = p;
        }


        void Kullanıcı(string kullaniciadi) 
        {
            ViewBag.v = kullaniciadi;
        }

        int Topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }


        int Faktoriyel(int p)
        {
            // 4! --> 1*2*3*4
            // 1*1=1
            // 1*2=2
            // 2*3=6
            // 6*4=24

            int f = 1;
            for (int i = 1; i <= p; i++) 
            {
                f = f * i;
            }
            return f;
        }



        public IActionResult Index()
        {
            mesajlar();         
            ViewBag.t = Topla();
            MesajListesi("Parametre İsmi");
            Kullanıcı("üye123");

            ViewBag.tp = Topla(20,35);

            ViewBag.faktor = Faktoriyel(4);

            return View();
        }

        public IActionResult Urunler() 
        { 
            mesajlar();
            ViewBag.t = Topla();
            ViewBag.c = Cevre();
            ViewBag.d = cumle();

            Kullanıcı("member000");

            return View();
        }

        public IActionResult Musteriler()
        {
            ViewBag.d = cumle();

            Kullanıcı("admin004");
            return View();
        }

        public IActionResult Deneme()
        { 
            Sehirler sehirler = new Sehirler(); //nesne türettik
            Bayrak bayrak = new Bayrak();


            sehirler.Ad = "Zurih";  //propertilere değer atamsı yapıldı
            sehirler.Id = 1;
            sehirler.Nufus = 100000;
            sehirler.Ulke = "İsviçre";
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Beyaz";

            ViewBag.v1 = sehirler.Id;  //değerlerin ekrana yazdırılması
            ViewBag.v2 = sehirler.Ulke;  
            ViewBag.v3 = sehirler.Ad;
            ViewBag.v4 = sehirler.Nufus;

            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;
            ViewBag.v7 = sehirler.Renk3;





            sehirler.Id = 2;
            sehirler.Ad = "Berlin";
            sehirler.Nufus = 8000000;
            sehirler.Ulke = "Almanya";
            sehirler.Renk1 = "Siyah";
            sehirler.Renk2 = "Kırmızı";
            sehirler.Renk3 = "Sarı";

            ViewBag.z1 = sehirler.Id;  
            ViewBag.z2 = sehirler.Ulke;
            ViewBag.z3 = sehirler.Ad;
            ViewBag.z4 = sehirler.Nufus;

            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;
            ViewBag.z7 = sehirler.Renk3;




            return View();

        }



    }
}
