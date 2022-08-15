
Console.WriteLine("sayı: (2'den büyük veya eşit):");
//int sayi = Convert.ToInt32(Console.ReadLine());
int giris = int.Parse(Console.ReadLine());
int sayi = 2;
bool asalmi = true;
if (giris > 2)



{
    do
    {
        if (giris % sayi == 0)
        {
            asalmi = false;
            break;
        }
        sayi++;
    } while (sayi < giris);

}
if (asalmi == true)
    Console.WriteLine("Asal");
else
    Console.WriteLine("değil");