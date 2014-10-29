using System;
using System.Windows.Forms;
	
class HelloWorld	{
	public static void Main()
	{
		System.Console.WriteLine("Hello world");
		
		for(int i=0; i <10; i++){
			System.Console.WriteLine("a ");
		}

		string a = System.Console.ReadLine();

		if(a=="abc")
			System.Console.WriteLine("foi digitado: " + a);
		else
			System.Console.WriteLine("Nada foi digitado		");

		MessageBox.Show("Acabou!!!");

		Tchau e = new Tchau();
	}



}

class Tchau		{
		System.Console.WriteLine("aloooo");
}