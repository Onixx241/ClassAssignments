class Calc
{
    public int a { get; set; }
    public int b { get; set; }

    public Calc(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public int Operations(int choice)
    {
        switch (choice)
        {
            case 1:
                return this.a + this.b;

            case 2:
                return this.a - this.b;

            case 3:
                return this.a * this.b;

            case 4:
                return this.a / this.b;
        }

        return 0;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's the first Number?");
        int answer1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What's the second number?");
        int answer2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What Operation?\n1)Addition\n2)Subtraction\n3)Multiplication\n4)Division");

        int choice = Convert.ToInt32(Console.ReadLine());

        Calc Calculator = new Calc(answer1, answer2);

        int result = Calculator.Operations(choice);

        Console.WriteLine(result);
    }
}