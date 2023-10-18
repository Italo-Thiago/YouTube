// Loop FOR - Estrutura de iteração


using System;

class Program{

	static void Main(){

    int[] num=new int[10]; // declaração de um array do tipo inteiro

    for(int i=0;i<num.Length;i++){ // enquanto (declaração de variável local | teste lógico | incremento ou decremento)
      num[i]=0;
      Console.WriteLine("Valor de num na pos {0}: {1}",i,num[i]);
    }
	
	}
}