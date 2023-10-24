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
}

class Program{

	static void Main(){
	
    Car c1;

    c1.brand="VW";
    c1.model="Golf";
    c1.color="Azul";
//
    Car c2; 

    Console.WriteLine("Marca....:{0}",c1.brand);
    Console.WriteLine("Modelo...:{0}",c1.model);
    Console.WriteLine("Cor......:{0}",c1.color);
	
	}
}
