class Adder 
{
	public int a { get; set; }
	public int b { get; set; }

	public Adder(int a,int b) 
	{
		this.a = a;
		this.b = b;
	}

	public int Add()
	{
		return a + b;
	}

}

class Program 
{
	static void Main( string[] args )
	{
		Console.WriteLine("What's the first Number?");
		int answer1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("What's the second number?");
		int answer2 = Convert.ToInt32(Console.ReadLine());
		
		Adder adder = new Adder( answer1, answer2 );
		int result = adder.Add();

		Console.WriteLine( result );
	}
}
