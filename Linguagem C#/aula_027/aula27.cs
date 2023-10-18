// Argumento params

using System;

class Program{

	static void Main(){
    soma(10,200,39,8208,89928,9938);
	
	}

  static void soma(params int[]n){
    int res=0;

    if(n.Length < 1){
      Console.WriteLine("Não existem valores a serem somados");
    }else if(n.Length < 2){
      Console.WriteLine("Valores insuficiente para soma: {0}",n[0]);
    }else{
      for(int i=0;i<n.Length;i++){
        res+=n[i];
      }
      Console.WriteLine("A soma dos valores é: {0}",res);
    }
  }
}