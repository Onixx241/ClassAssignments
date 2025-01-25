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

		Adder adder = new Adder( 1, 2 );
		int result = adder.Add();

		Console.WriteLine( result );
	}
}