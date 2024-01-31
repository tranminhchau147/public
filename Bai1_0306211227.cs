namespace Program
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int number;
            int largest = int.MinValue;
            Console.WriteLine("Nhap vao 10 so nguyen:");
            while (counter < 10)
            {
                Console.Write($"Nhap so thu {counter + 1}: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > largest)
                    {
                        largest = number;
                    }
                    counter++;
                }
                else
                {
                    Console.WriteLine("Nhap khong hop le, vui long nhap lai.");
                }
            }
            Console.WriteLine($"Gia tri lon nhat trong 10 so vua nhap la: {largest}");
        }
    }
}