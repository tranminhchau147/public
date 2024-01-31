namespace Program
{
    internal class Bai7_0306211227
    {
        static int DemSo(int a)
        {
            int count = 0;
            while (a > 0)
            {
                a /= 10;
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Nhap vao so nguyen duong(-1 de ket thuc): ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == -1)
                {
                    break;
                }
                if (number <= 0)
                {
                    Console.WriteLine("Vui long nhap so nguyen duong. Yeu cau nhap lai.");
                    continue;
                }
                int dem = DemSo(number);
                Console.WriteLine($"So {number} co {dem} ky so");
         
            }
            
        }
    }
}
