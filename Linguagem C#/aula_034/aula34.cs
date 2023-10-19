// Herança
// O código está com erro mais serve para entender o conceito 

using System;

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
    public string getLigado(){
      if(active){
        return "sim";
      }else{
        return "não";
      }
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

      Console.WriteLine("Cor.......:{0}",c1.color);
      Console.WriteLine("Noma......:{0}",c1.name);
      Console.WriteLine("Rodas.....:{0}",c1.wheels);
      Console.WriteLine("Vel.Maxima:{0}",c1.velMax);
      Console.WriteLine("Ligado....:{0}",c1.getLigado());
    }
  }
