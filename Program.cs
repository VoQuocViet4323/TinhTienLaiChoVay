internal class Program
{
    private static void Main(string[] args)
    {
        double money = 1.0;
        int month = 1;
        double laisuat = 1.0;

        Console.WriteLine("Nhap so tien gui: ");
        money = Double.Parse(Console.ReadLine());

        Console.WriteLine("Nhap so thang gui tien: ");
        month = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Nhap lai suat: ");
        laisuat = Double.Parse(Console.ReadLine());

        double TongTienLai = 0;
        for (int i = 0; i < month; i++)
        {
            TongTienLai = money * (laisuat / 100) / 12 * 3;
        }
        Console.WriteLine("Total of interset: " + TongTienLai);
    }
}