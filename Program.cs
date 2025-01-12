using SatrancTaslari_v2.Abstract;
using SatrancTaslari_v2.Data;

namespace SatrancTaslari_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random SatrancTasOlusturucu = new Random();
            int RandomTasIndex, RandomRenkIndex;
            List<string> Renkler = new List<string>() { "Siyah", "Beyaz" };
            List<Type> Taslar = new List<Type>() { typeof(Pawn), typeof(Rook), typeof(Knight), typeof(Bishop), typeof(Queen), typeof(King) };

            Piece GeneratedTas;
            List <Piece> GeneratedTaslar = new List<Piece>();

            List<string> TasListesi = new List<string>();
            List<int> TekrarSayilari = new List<int>();

            Console.WriteLine("Oluşturmak istediğiniz taş sayısını giriniz.");
            int OlusturulcakTasSayisi = int.Parse(Console.ReadLine());
            for (int i = 0; i < OlusturulcakTasSayisi; i++)
            {
                RandomTasIndex = SatrancTasOlusturucu.Next(0, Taslar.Count);
                RandomRenkIndex = SatrancTasOlusturucu.Next(0, Renkler.Count);
                GeneratedTas = (Piece)Activator.CreateInstance(Taslar[RandomTasIndex]);
                GeneratedTas.Name = Taslar[RandomTasIndex].Name;
                GeneratedTas.Color = Renkler[RandomRenkIndex];
                GeneratedTaslar.Add(GeneratedTas);

                string TasKey = $"{GeneratedTas.Name} {GeneratedTas.Color}";
                int index = TasListesi.IndexOf(TasKey);
                if (index != -1)
                {
                    TekrarSayilari[index]++;
                }
                else
                {
                    TasListesi.Add(TasKey);
                    TekrarSayilari.Add(1);
                }
            }
            Console.WriteLine("Taşlarınız oluşturuldu.");
            foreach (var tas in GeneratedTaslar)
            {
                Console.WriteLine("==================================================");
                Console.WriteLine(tas.Name + " " + tas.Color);
                tas.Move();
                if(tas.GetType() == typeof(Pawn))
                {
                    ((Pawn)(tas)).Promote();
                }
            }
            Console.WriteLine("\nTaşların tekrar eden sayıları:");
            for (int i = 0; i < TasListesi.Count; i++)
            {
                Console.WriteLine($"{TasListesi[i]}: {TekrarSayilari[i]} kez");
            }
            int maxRepeat = TekrarSayilari.Max();
            Console.WriteLine("\nEn çok tekrar eden taşlar:");
            for (int i = 0; i < TasListesi.Count; i++)
            {
                if (TekrarSayilari[i] == maxRepeat)
                {
                    Console.WriteLine($"{TasListesi[i]}: {TekrarSayilari[i]} kez");
                }
            }
        }
    }
}
