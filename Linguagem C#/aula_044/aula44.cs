// Struct

using System;

struct Car{
  public string brand;
  public string model;
  public string color;

  public Car(string brand,string model,string color){
    this.brand=brand;
    this.model=model;
    this.color=color;
  }

  public void info(){
    Console.WriteLine("Marca.: {0}",this.brand);
    Console.WriteLine("Modelo: {0}",this.model);
    Console.WriteLine("Cor...: {0}",this.color);
  }
}

class Program{

	static void Main(){
	
	  Car c1=new Car("Honda","HRV","Prata");
	  Car c2=new Car("VW","Golf","Azul");

	  c1.info();
	  c2.info();
	}
}
