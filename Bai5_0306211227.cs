namespace Program
{
    internal class Bai5_0306211227
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
                Console.Write("Nhap 2 so nguyen(-1 de ket thuc): ");
                string input = Console.ReadLine();
                string[] number = input.Split(' ');
                if (Convert.ToInt32(number[0]) == -1)
                {
                    break;
                }
                if (number.Length != 2)
                {
                    Console.WriteLine("Nhap khong hop le. Vui long nhap 2 so nguyen.");
                    continue;
                }
                int num1 = Convert.ToInt32(number[0]);
                int num2 = Convert.ToInt32(number[1]);
                int ucln = UCLN(num1, num2);
                Console.WriteLine($"Uoc so chung lon nhat: {ucln}");
            }
        }
    }
}
