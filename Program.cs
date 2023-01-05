namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Volume = ");
            var volume = Double.Parse(Console.ReadLine());

            Console.Write("Debit pipe 1 = ");
            var p1 = Double.Parse(Console.ReadLine());

            Console.Write("Debit pipe 2 = ");
            var p2 = Double.Parse(Console.ReadLine());

            Console.Write("Vreme = ");
            var time = Double.Parse(Console.ReadLine());

            var full = (p1 + p2)*time*100 / volume;

            if (full>100)
            {
                var prepalnen = (full - 100)*volume/100;
                Console.WriteLine("Za" + time + "chasa Baseyna e prepalnen s " + prepalnen + " litra");
                                
            }
            else
            {
                var p11 = p1 * time * 100 / full;
                var p22 = p2 * time * 100 / full;
                Console.WriteLine("Baseyna e palen na " + full + "%");
                Console.WriteLine("Pipe 1 = " + Math.Round(p11, 2) + "%");
                Console.WriteLine("Pipe 2 = " + Math.Round(p22, 2) + "%");
            }
            



        }
    }
}