namespace Program
{
    internal class Bai4_0306211227
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Nhap doanh thu cua nhan vien(-1 de ket thuc): ");
                double dt = Convert.ToDouble(Console.ReadLine());
                if (dt == -1)
                {
                    break;
                }
                if (dt <= 0)
                {
                    Console.WriteLine("Doanh thu phai lon hon 0. Vui long nhap lai.");
                    continue;
                }
                double luong = 200 + (dt * 0.09);
                Console.WriteLine($"Luong cua nhan vien la: ${luong:F2}");
            }
        }
    }
}
