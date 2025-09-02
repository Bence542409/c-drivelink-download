using System.Diagnostics;

namespace drivelink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Megosztott mappa URL: ");
            string link = Console.ReadLine();
            link = link.Remove(0, 39);
            link = "https://drive.google.com/uc?export=download&id=" + link;
            link = link.Remove(link.Length - 12, 12);
            Console.Write("Letöltő URL: "+link);
        }
    }
}
