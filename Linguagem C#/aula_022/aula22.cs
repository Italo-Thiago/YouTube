// Loop FOREACH / Estrutura de iteração

using System;

class Program{

	static void Main(){
	
    int[] num=new int[3]{11,22,33};

    // for(int i=0;i<num.Length;i++){
    //   Console.WriteLine(num[i]);
    // }
	
    foreach(int n in num){ // a variável de iteração do foreach teve ser do menso tipo do array.
      Console.WriteLine(n); // Somente leitura, não e possível fazer atribuição no foreach.
    }
	}
}