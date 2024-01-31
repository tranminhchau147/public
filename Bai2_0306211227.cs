namespace Program
{
    internal class Bai2_0306211227
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int number;
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            Console.WriteLine("Nhap vao 10 so nguyen:");

            while (counter < 10)
            {
                Console.Write($"Nhap so thu {counter + 1}: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > largest)
                    {
                        secondLargest = largest;
                        largest = number;
                    }
                    else if (number > secondLargest)
                    {
                        secondLargest = number;
                    }
                    counter++;
                }
                else
                {
                    Console.WriteLine("Nhap khong hop le, vui long nhap lai.");
                }
            }

            Console.WriteLine($"Hai gia tri lon nhat trong 10 so vua nhap la: {largest} va {secondLargest}");
        }
    }
}
