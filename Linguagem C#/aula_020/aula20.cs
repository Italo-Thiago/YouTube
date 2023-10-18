// Loop While / Estrutura de iteração

using System;

class Program{

	static void Main(){
    
    int i=0; // E necessário declarar a variável que será usado no teste lógico fora do while

    int[] num=new int[10]; 

    // while(i<10){
    //   Console.WriteLine("Dia: " + i);
    //   i++; // O incremento ou decremento deve mudar de local dependendo da necessidade do programador.
    // }

    // while(i<num.Length){
    //   num[i]=0;
    //   Console.WriteLine(num[i]);
    //   i++;
    // } 

    int i=num.Length-1;
    while(i>0){
      num[i]=0;
      Console.WriteLine(num[1]);
      i--;
    }
    Console.WriteLine("Fim do loop");
    
	}
}