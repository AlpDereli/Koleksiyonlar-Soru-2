// See https://aka.ms/new-console-template for more information
int[] sayilar = new int[20];
for (int i = 0; i<20; i++)
{
    Console.WriteLine("Sayi Giriniz: ");
    int sayi = int.Parse(Console.ReadLine());
    sayilar[i] = sayi;
}
for (int i = 0;i<20; i++)
{
    for (int j = 0;j<20; j++)
    {
        if (i > j && sayilar[i] < sayilar[j])
        {
            int deger = sayilar[j];
            sayilar[j] = sayilar[i];
            sayilar[i] = deger;
        }
    }
}
Console.WriteLine("En kucuk degerler: ");
Console.WriteLine(sayilar[0]);
Console.WriteLine(sayilar[1]);
Console.WriteLine(sayilar[2]);
Console.WriteLine("En buyuk degerler: ");
Console.WriteLine(sayilar[17]);
Console.WriteLine(sayilar[18]);
Console.WriteLine(sayilar[19]);
int toplam1 = sayilar[0] + sayilar[1] + sayilar[2];
int toplam2 = sayilar[17] + sayilar[18] + sayilar[19];
double ort1 = toplam1 / 3;
double ort2 = toplam2 / 3;
double orttop = ort1 + ort2;
Console.WriteLine("En kucuklerinin ort: " + ort1);
Console.WriteLine("En buyuklerinin ort: " + ort2);
Console.WriteLine("Ort toplamları: " + orttop);

