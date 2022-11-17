namespace Addition
{
    public class Add
    {
        public int Main(int num1, int num2)
        {
            Console.Write("Enter 1st number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            num2 = int.Parse(Console.ReadLine());
            return num1 + num2;

        }
    }
}
