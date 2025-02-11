namespace MojeSrodowisko
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Environment.OSVersion.VersionString);
            Console.WriteLine("Przestrzeń nazw: {0}", typeof(Program).Namespace);

        }
    }
}
