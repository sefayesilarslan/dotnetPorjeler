namespace stringler
{
    class stringdiziler{

        public static void Main(string[] args){
            
        //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        Console.WriteLine("Bir cümle yaziniz : ");

        string kelime=Console.ReadLine();

        string[] dizi = kelime.Split(" "); 
        
        int elemanSayisi = dizi.Count(); 

        Console.WriteLine("Cümledeki kelime sayisi : "+elemanSayisi);
        
        string birlestirildi=kelime.Replace(" ","");
        int harfsayisi = birlestirildi.Count(); 
        Console.WriteLine("Harf sayisi : "+harfsayisi);

        }
    }
}