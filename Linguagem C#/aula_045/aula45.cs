// Array de estruturas

using System;

struct Car{
  public string model;
  public string color;

  public void info(){
    Console.WriteLine("Modelo: {0}",this.model);
    Console.WriteLine("Cor...: {0}",this.color);
    Console.WriteLine("----------------------");
  }
}

class Program{
	static void Main(){

	  // A sintaxe e muito parecida com a declaração de um array.  
    int[] numeros=new int[10];

    Car[] cars=new Car[4];

    cars[0].model="HRV";
    cars[0].color="Prata";
    
    cars[1].model="Golf";
    cars[1].color="Azul";

    cars[2].model="Jetta";
    cars[2].color="Branco";

    cars[3].model="Argo";
    cars[3].color="Preto";

    for(int i=0; i<cars.Length;i++){
      cars[i].info();
    }
	}
}
