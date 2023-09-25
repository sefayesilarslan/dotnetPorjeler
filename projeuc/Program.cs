namespace stringler
{
    class stringdiziler{

        public static void Main(string[] Args){
           
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.WriteLine("Dizi Uzunlugunu girin");

            int dizi_uzunlugu=int.Parse(Console.ReadLine());

            string[] dizi= new string[dizi_uzunlugu];

            for (int i = 0; i < dizi_uzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. kelimeyi girin. ",i+1);
                dizi[i]=Console.ReadLine();
            }

            Console.WriteLine("**********");

            Array.Reverse(dizi);
            
            foreach (var elemanlar in dizi)
            {
                Console.WriteLine(elemanlar);
            }
        }
    }
}