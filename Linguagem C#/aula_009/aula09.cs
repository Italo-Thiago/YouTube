// Operações de Bitwase

using System;

class Program{

	static void Main(){

    // << Dobra
    // >> Divide pela Metade
	
    Console.WriteLine("Digite um número para ser dobrado");
    int num = int.Parse(Console.ReadLine());
    num = num << 1;
    Console.WriteLine("O resultado é :{0}", num);
	
	}
}