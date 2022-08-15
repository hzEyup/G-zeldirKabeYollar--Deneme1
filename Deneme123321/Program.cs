namespace İsimSorgulama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] KullaniciAdlari = new string[4]
            {
                "niçe",
                "pluton",
                "sokrates",
                "farabi"

            };

            string[] Sifreler = new string[4]
            {
                "niçe1",
                "pluton1",
                "sokrates1",
                "farabi1"
            };
            
            Console.WriteLine("Kullanıcı adı: ");
            string giris = Console.ReadLine();
            bool girisBasarili = false;
            foreach (string kullaniciAdi in KullaniciAdlari)
            

            {
                if (giris == kullaniciAdi)
                {
                    girisBasarili = true;

                    Console.WriteLine("sifre giriniz: ");
                    string Sgiris = Console.ReadLine();
                    bool SgirisBarasili = false;



                }

            }
            if (girisBasarili)
            {
                Console.WriteLine("giris Başarılı");

            }
            else
            {
                Console.WriteLine("giriş başarısız");

            }
        }


    }
}