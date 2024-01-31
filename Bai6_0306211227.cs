namespace Program
{
    internal class Bai6_0306211227
    {
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Nhap mot phan so(-1 de ket thuc): ");
                string ps = Console.ReadLine();
                string[] part = ps.Split('/');
                if (Convert.ToInt32(part[0]) == -1)
                {
                    break;
                }
                if (part.Length != 2)
                {
                    Console.WriteLine("Nhap khong hop le. Vui long nhap mot phan so co dang a/b.");
                    return;
                }
                int tuso = Convert.ToInt32(part[0]);
                int mauso = Convert.ToInt32(part[1]);
                if (tuso == -1 || mauso == -1)
                {
                    break;
                }
                if (mauso == 0)
                {
                    Console.WriteLine("Mau so (b) khong the la 0. Vui long nhap lai.");
                    return;
                }
                // Rút gọn phân số
                int ucln = UCLN(tuso, mauso);
                int tsrutgon = tuso / ucln;
                int msrutgon = mauso / ucln;

                Console.WriteLine($"Phan so sau khi rut gon: {tsrutgon}/{msrutgon}");
            }
        }
    }
}
