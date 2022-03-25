using System;
namespace asp.net
{
	class sample
	{
		public static int add()
		{
			int num1 = 10 ; 
 			int  num2 = 20;

			return (num1 + num2);
		}

		public static void Main(String [] args)
		{
			Console.WriteLine("Hello From niit Jadavpur");
			Console.WriteLine("Addition of the numbers is : " + sample.add());
			String studentName = "";
			int age=0;
			Console.WriteLine("Plaese enter your Name :");
			studentName = Console.ReadLine();

			Console.WriteLine("Plaese enter your Age :");
			//age= Convert.ToInt32(Console.ReadLine());
			age= Int32.Parse(Console.ReadLine());

			Console.WriteLine("Welcome " + studentName +" to Niit Jadavpur");
			Console.WriteLine("Your Age is " + age );
			
		}
	}
}