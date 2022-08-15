namespace yazıTuraXX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yazımı (y) turamı (t) çıkmak için (ç)");
            string giris = Console.ReadLine();
            Random rastgele = new Random();
            int sayi;
            int yaziTura;
            double oynamaSayisi =0;
            double bilmesayisi=0;
            while (giris !="ç")
            {

                sayi = rastgele.Next(0,2);
                //if (giris == "y")
                //    yaziTura = 0;
                //else
                //    yaziTura =1;


                yaziTura = giris == "y" ? 0 : 1;   //ternary operator
                if(yaziTura == sayi)
                {
                    Console.WriteLine("bildiniz");
                    bilmesayisi++;
                }
                else
                {
                    Console.WriteLine("bilemediniz");

                }

                Console.WriteLine("yazımı turamı çıkmak için (Ç)");
                giris = Console.ReadLine();
                oynamaSayisi++;
            }


            if (oynamaSayisi  > 0)
            {
                double sans = bilmesayisi * 100 / oynamaSayisi;
                if (sans >= 50)
                    Console.WriteLine("hadi yine iyisin şanslı günün :" + sans);
                else
                {
                    Console.WriteLine("bugün evde çıkma ");

                }

            }        
        
        }
    }
}