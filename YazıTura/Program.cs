
Console.WriteLine("yazı (y) mı turamı(t)?");
string giris = Console.ReadLine();

  

while (giris == "y" || giris == "t")

{

    bool YaziMi = true;

    Random rastgele = new Random();
    int rastgeleSayi = rastgele.Next(2);

    YaziMi = Convert.ToBoolean(rastgeleSayi);




    string yaziTura = YaziMi == true ? "y" : "t";//   > ikinci yol ternary operator


    if (yaziTura == giris)
        Console.WriteLine("wp bro bildin");
    else

        Console.WriteLine("nt kardeşim");







    Console.WriteLine("yazı (y) mı turamı(t)?");
    giris = Console.ReadLine();
    break;

}

//string yaziTura;
//if (YaziMi == true) ---   overload
//    yaziTura = "y";
//else
//    yaziTura
//    t
//    = "t";     >   birinci yol ( uzun sorgularda kulalnılır)