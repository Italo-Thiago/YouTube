// Herança

/using System;

class Program{

	class Veiculo{ // Classe Base
    public int wheels;
    public int velMax;
    public bool active;
    public void ligar(){
      active=true;
    }
    public void desligar(){
      active=false;
    }
  }
  class Carro:Veiculo{ // Derivada|Base
    public string name;
    public string color;
    public Carro(string color, string name){
      desligar();
      wheels=4;
      velMax=120;
      this.name=name;
      this.color=color;
    }
  }

  static void Main(){
	
  Carro void Main(){
    Carro c1=new Carro("Fast","red");

    Console.WriteLine("Cor...:{0}")
  }
	
	}
}