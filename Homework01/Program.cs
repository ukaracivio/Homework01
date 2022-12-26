internal class Program
{
    private static void Main(string[] args)
    {
        char Choice;
        int MenuOption;
        int Number1, Number2;

        int sayi1, sayi2;



        do
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine("=== Menü ===\n");
            Console.WriteLine("1. Toplama kullanarak çarpma işlemi");
            Console.WriteLine("2. 1-100 arasındaki tüm asal sayılar");
            Console.WriteLine("3. 6 basamaklı sayının basamaklarındaki sayıların toplamı");
            Console.WriteLine("4. Ara sınav ve genel sınav");
            Console.WriteLine("5. 100 ler hanesi 1 ler hanesi");
            Console.WriteLine("6. Bankamatik");
            Console.WriteLine("");
            Console.WriteLine("Seçiminiz : ");

            MenuOption = Convert.ToInt32(Console.ReadLine());

            switch (MenuOption)
            {
                case 1:
                    int sonuc = 0;
                    Console.Write("Çarpılacak 1.sayıyı giriniz : ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Carpilacak 2. sayıyı giriniz : ");
                    sayi2 = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= sayi2; i++)
                        sonuc += sayi1;

                    Console.WriteLine("Toplama kullanarak çarpma işleminin sonucu : " + sonuc);
                    break;
                case 2:
                    int sayac = 0;

                    for (int asalsayi = 2; asalsayi <= 100; asalsayi++)
                    {
                        int kontrol = 0;

                        for (int i = 2; i < asalsayi; i++) // Asal sayılar 2'den başlar
                        {
                            if (asalsayi % i == 0) // Kalan 0 ise asaldır
                            {
                                kontrol = 1;
                                break;
                            }
                        }

                        if (kontrol == 0)
                        {
                            Console.WriteLine("{0} asaldır.", asalsayi);
                            sayac++;
                        }

                    }
                    Console.WriteLine("========================");
                    Console.WriteLine("1-100 arasında {0} adet asal sayı vardır...", sayac);
                    Console.ReadKey();
                    break;
                case 3:
                    int sayi, uzunluk,toplam = 0;
                    string girilen;
                    int yuzbinler,onbinler,binler,yuzler, onlar, birler;

                    Console.WriteLine("Lütfen bir sayı giriniz : "); 

                    girilen = long.Parse(Console.ReadLine()).ToString();

                    uzunluk = girilen.Length;

                    if (uzunluk == 6) // hane sayısı kontrol
                    {
                        sayi = Convert.ToInt32(girilen);

                        yuzbinler = sayi / 100000; sayi = sayi - (yuzbinler * 100000);
                        onbinler = sayi / 10000; sayi = sayi - (onbinler * 10000);
                        binler = sayi / 1000; sayi = sayi - (binler * 1000);
                        yuzler = sayi / 100; sayi = sayi - (yuzler * 100);
                        onlar = sayi / 10; sayi = sayi - (onlar * 10);
                        birler = sayi;

                        toplam = yuzbinler + onbinler + binler + yuzler + onlar + birler;

                        // yada Esmanur yolu

                        //while (sayi > 0)
                        //{
                        //    toplam += sayi % 10;
                        //    sayi /= 10;
                        //}

                        Console.WriteLine("Haneler toplamı : {0}",toplam);
                    }
                    else
                    {
                        Console.WriteLine("Lütfen 6 haneli bir sayı giriniz.....");
                    }

                    break;
                case 4:
                    int aras1, aras2, gens;

                    Console.WriteLine("1. arasinav notunu giriniz : ");
                    aras1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("2. arasinav notunu giriniz : ");
                    aras2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Genel sinav notunu giriniz : ");
                    gens = Convert.ToInt32(Console.ReadLine());

                    var gecmenot = (0.2 * aras1) + (0.3 * aras2) + (0.5 * gens);

                    Console.WriteLine("Sonuç puani : " + gecmenot);
                    break;
                case 5:
                    
                    
                    Console.WriteLine("Lütfen bir sayı giriniz : ");
                    string gsayi = Console.ReadLine();

                    string grln = long.Parse(Console.ReadLine()).ToString();

                    uzunluk = grln.Length;

                    if (uzunluk == 4)
                    {
                        int hundreds = Convert.ToInt32(gsayi[1]);
                        int singles = Convert.ToInt32(gsayi[3]);

                        sonuc = (hundreds % 3) - singles;

                        Console.WriteLine("Sonuc : " + sonuc);
 
                    }
                    else
                        goto case 5;

                    break;


                case 6:
                    Console.WriteLine("Cekmek isteyeceginiz para tutarini giriniz");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    int kalanPara;


                    do
                    {
                        var ikiyuzSayisi = tutar / 200;
                        if (ikiyuzSayisi > 0)
                            Console.WriteLine(ikiyuzSayisi + " tane 200tl");

                        kalanPara = tutar - ikiyuzSayisi * 200;

                        //if (kalanPara == 0)
                        //    return;

                        var yuzlukSayisi = kalanPara / 100;
                        if (yuzlukSayisi > 0)
                            Console.WriteLine(yuzlukSayisi + " tane 100tl");

                        kalanPara -= yuzlukSayisi * 100;

                        //if (kalanPara == 0)
                        //    return;

                        var ellilikSayisi = kalanPara / 50;
                        if (ellilikSayisi > 0)
                            Console.WriteLine(ellilikSayisi + " tane 50tl");

                        kalanPara -= ellilikSayisi * 50;

                        //if (kalanPara == 0)
                        //    return;

                        var yirmilikSayisi = kalanPara / 20;
                        if (yirmilikSayisi > 0)
                            Console.WriteLine(yirmilikSayisi + " tane 20tl");

                        kalanPara -= yirmilikSayisi * 20;

                        //if (kalanPara == 0)
                        //    return;

                        var onlukSayisi = kalanPara / 10;
                        if (onlukSayisi > 0)
                            Console.WriteLine(onlukSayisi + " tane 10tl");

                        kalanPara -= onlukSayisi * 10;

                        //if (kalanPara == 0)
                        //    return;

                        var beslikSayisi = kalanPara / 5;
                        if (beslikSayisi > 0)
                            Console.WriteLine(beslikSayisi + " tane 5tl");

                        kalanPara -= beslikSayisi * 5;

                        if (kalanPara == 0)
                            return;
                        else
                            Console.WriteLine(kalanPara + "tl verilemedi!");

                    } while (kalanPara == 0);


                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen kontrol ediniz....");
                    break;
            }
            Console.WriteLine("Devam etmek istiyor musunuz(E), çıkmak için herhangi bir tuşa basınız...");

            Choice = Convert.ToChar(Console.ReadLine());




        } while (Char.ToUpper(Choice) == 'E');











    }
}