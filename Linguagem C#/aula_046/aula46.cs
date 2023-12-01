// Métodos que retornam objetos

using System;

class Chicken{
  private string nameChicken;
  private int numEgg;

  public Chicken(string name){
    this.nameChicken=nameChicken;
    numEgg=0;
  }
// Abaixo temos um método chamado put(), que recebe o objeto "Egg" e retorna um novo objeto "Egg()"
  public Egg put(){
    numEgg++;
    return new Egg(numEgg,nameChicken);
  }
}

class Egg {
  private int numEgg;
  private string myChicken;

  public Egg(int numEgg, string myChicken){
    this.numEgg=numEgg;
    this.myChicken=myChicken; 
    Console.WriteLine("Ovo criado: {0} - {1}", this.numEgg,this.myChicken);
  }
}

class Program{

	static void Main(){
	
    Chicken g1=new Chicken("Benetida");
    Chicken g2=new Chicken("Felizberta");
    Chicken g3=new Chicken("Marisol");

    g1.put();

	}
}
