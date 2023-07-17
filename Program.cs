using System;

class Program
{
	public static int LerNumero (){
		
		return Convert.ToInt32(Console.ReadLine());
	}
	
	public static void OrdemCrescente(){
		
		int a, max=0, min=0, med=0;
		
		for (int i = 1; i <= 3; i++){
			
			Console.WriteLine("Insira um número:");
			
			a = LerNumero();
			
			if (i == 1){
				max = a;
				med = a;
				min = a;
		
			} else if (a > max){
				
				med = max;
				max = a;
				
			} else if ( a > med) {
				
				min = med;
				med = a;
				
				
			} else if (a < min){
				med = min;
				min = a;
			}
			
		}
		Console.WriteLine("Por ordem crescente:");
		Console.WriteLine(min);
		Console.WriteLine(med);
		Console.WriteLine(max);
		
	}
	static void Main(string[] args)
	{
		OrdemCrescente();
	}
}