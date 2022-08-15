//for (int i = 65; i <= 90; i++)
//{

//    //Console.WriteLine(Convert.ToChar(i));
//    Console.Write((char)i+" ");


//}    
for (char k = 'A'; k< 'Z';k++)
{
    if((k>= 'A' && k<= 'Z') || ( k>= 'a' && k <= 'z'))
    Console.Write(k + " ");



}
Console.WriteLine();
int fark = 'a' - 'A';
Console.WriteLine(fark);


for (char k = 'A'; k<= 'Z'; k++)
{
    Console.Write(k + " " + (char)(k + 32) + " ");

}

