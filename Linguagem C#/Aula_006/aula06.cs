// Formatando a saída no Console

using System;

class aula06{

	static void Main(){
	
		// int n1, n2, n3;
		// n1 = 10; n2 = 20; n3 = 30;
		// Console.Write("\tn1={0}, \nn2={1}, \nn3={2}",n1,n2,n3);

		double valorCompra = 5.50;
		double valorVenda;
		double lucro = 0.1;
		string produto = "Pastel";

		Console.WriteLine("Produto........:{0,15}",produto); // Pastel
		Console.WriteLine("Val.Compra.....:{0,15:c}",produto); // R$ 5,50
		Console.WriteLine("Lucro..........:{0,15:p}",lucro); // 10,00%
		Console.WriteLine("Val.Venda......:{0,15:c}",valorVenda); // 6,05
		
	
	}
}