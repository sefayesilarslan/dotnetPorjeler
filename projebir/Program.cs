namespace odev
{

    class ciftsayilar
    {

        public static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            
            Console.WriteLine("Dizinin eleman sayisini girin : ");

            int dizi_uzunlugu=int.Parse(Console.ReadLine());

            int[] dizi = new int[dizi_uzunlugu];

            for (int i = 0; i < dizi_uzunlugu; i++)
            {
                Console.Write("Lütfen {0} sayiyi giriniz.", i+1);
                dizi[i]=int.Parse(Console.ReadLine());
            }

            foreach (var sayi  in dizi)
            {
                if (sayi%2==0)
                {
                    Console.WriteLine(sayi);
                }
                
            }
        }
    }
}