namespace Program
{
    internal class Bai3_0306211227
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Hay nhap vao so lit xang da dung (-1 de ket thuc): ");
                double lit = Convert.ToDouble(Console.ReadLine());

                if (lit == -1)
                {
                    break;
                }

                Console.Write("Hay nhap so km da di: ");
                double km = Convert.ToDouble(Console.ReadLine());

                if (km <= 0)
                {
                    Console.WriteLine("So km phai lon hon 0. Vui long nhap lai.");
                    continue;
                }

                double kmperlit = km / lit;
                Console.WriteLine($"So km/lit cho binh xang nay la: {kmperlit}");
            }
        }
    }
}
