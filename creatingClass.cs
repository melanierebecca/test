class Customer
{
	public int CusID;
	public string Name;
	public string Address;
	
	Customer()
	{
		CusID=0001;
		Name="MELLIE";
		Address="Home,Bandarawela"
	}
	public void display
	{
		Console.WriteLine("Customer ID="+CusID);
		Console.WriteLine("Customer Name="+Name);
		Console.WriteLine("Customer Address="+Address);
	}
	static void Main (string[]args)
	
	{
		Customer c1=new Customer();
		c1.display();
		Console.WriteLine(c1.CusID);
		Console.WriteLine(c1.Name);
		Console.WriteLine(c1.Address);
		Console.Read();
	}
}