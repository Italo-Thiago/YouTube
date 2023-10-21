// Acessors GET e SET

using System;

class Car{
  private int speedMax;
  public int sM{
  // não é obrigatório declarar set e nem get, podendo ser declarado somente um.
  // LEITURA
    get{
      return speedMax;
    }
  //ESCRITA
    set{
      if(value < 0){
        speedMax=0;
      }else if(value>300){
        speedMax=300;
      }else{
        speedMax=value;
      }
    }
  }
  public Car(){
    sM=120;
  }
}

class Program{

	static void Main(){
	
    Car c1=new Car();

    c1.sM=200; //SET
    Console.WriteLine("Velocidade: {0}",c1.sM); //GET
	
	}
}