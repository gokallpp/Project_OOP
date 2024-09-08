using Proje_OOP.Entity;

namespace Proje_OOP.Ornekler
{

    //sınıfların içindeki ögelere erişim sağlamak için
    //sınıftan nesne türetilir

    //SınıfAdı nesneadı = new SınıfAdı();
    public class Class1
    {

       public void Topla()
        {
            int sayi1 = 10 ;
            int sayi2 = 20;

            int sonuc = sayi1 + sayi2;
        }

        void Carp()
        {
            int s1 = 10;
            int s2 = 20;

            int sonuc = s1 * s2;
        }

    }
}

// ProductClass --> Sınıf class
// productClass --> Nesne object
