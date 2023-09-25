namespace esitsayilar
{
    class esitlik{

        public static void Main(string[] Args){

            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.WriteLine("Dizinin Uzunlugunu girin : ");

            int dizi_boyutu=int.Parse(Console.ReadLine());

            Console.WriteLine("Karşilaştirilacak sayiyi girin : ");

            int karsilastirilacak_sayi=int.Parse(Console.ReadLine());

            int[] dizi = new int[dizi_boyutu];
            

            for (int i = 0; i < dizi_boyutu; i++)
            {
                Console.WriteLine("Lütfen {0} sayisini girin : ",i+1);
                dizi[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Eşit veya tam bölünen sayılar : ");
            foreach (var sayi in dizi)
            {
                if (sayi==karsilastirilacak_sayi || sayi%karsilastirilacak_sayi==0)
                {
                    Console.WriteLine(sayi);
                }
            }


        }
    }
}
