// Array | Vetor

using System;

class Program{

	static void Main(){
	
    // int n1,n2,n3,n4,n5;
    int[] n=new int[5]; // Um array sempre começa com 0
    int[] num=new int[3]{55,77,99}; // Outra forma de declarar um array porém atribuindo logo em seguida
    int[] numero={33,44,55,66,99}; // Esta forma de declaração e atribuição e mais indicada por diminuir a chance de erros por, automaticamente colocar o tamanho do array
    string[] veiculos=new string[3];

    veiculos[0]="Carro";
    veiculos[1]="Avião";
    veiculos[2]="Navio";

    n[0]=11;
    n[1]=22;
    n[2]=33;
    n[3]=44;
    n[4]=55;

    Console.WriteLine(n[0]);
    Console.WriteLine(num[2]);
    Console.WriteLine(numero[3]);
    Console.WriteLine(veiculos[1]); 
	
	}
}