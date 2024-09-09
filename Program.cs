namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ber användaren om en siffra och converterar sedan inputen till int
            Console.WriteLine("Ange en siffra: ");
            string num = Console.ReadLine();
            int intnum = Convert.ToInt32(num);
            //Om  numret som angavs är större än 10 skriver det ut att det var ett stort nummer annars skriver det att det var litet
            if (intnum > 10)
            {
                Console.WriteLine("Det numret var stort!");

            }
            else
            {
                Console.WriteLine("Det numret var litet!");
            }
            //Ber om ett namn och skriver sedan ut hej och ditt namn samt vilket nummer du angav
            Console.WriteLine("Skriv in ditt namn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hej " + name );
            Console.WriteLine("Du angav numret " + num );
            //För varje siffra i det angivna talet så upprepar loopen sig själv och skriver ut värdet på "i" i just den iterationen.
            //Den skriver ut hela vägen till talet då den upprepas så länge "i" är mindre ELLER lika med intnum.
            for (int i = 0; i <=intnum; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
