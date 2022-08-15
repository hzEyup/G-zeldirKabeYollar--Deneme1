namespace İsimSorgulama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = new string[4]
            {
                "niçe",
                "pluton",
                "sokrates",
                "farabi"

            };


            Console.WriteLine("ogrenci adı: ");
            string giris = Console.ReadLine();
            bool bulundu = false;
            foreach (string isim in isimler)

            {
                if (giris == isim)
                {
                    bulundu = true;
                    break;
                }
            }
            if (bulundu)
            {
                Console.WriteLine("isim bulundu");

            }
            else
            {
                Console.WriteLine("isim bulunmadı");

            }
        }


    }
}