// Membros Protected

using System;

class Vehicle{
  public int speedCurrent;
  private int speedMax;
  protected bool active;
  public Vehicle(int speedMax){
    speedCurrent=0;
    this.speedMax=speedMax;
    active=false;
  }
  public bool getActive(){
    return active;
  }
  public int getSpeedMax(){
    return speedMax;
  }
}
class Car:Vehicle{ // Derivada de Veículo
  public string name;
  public Car(string name, int sM):base(sM){
    this.name=name;
    // Como active e uma "protected" ele pode ser acessado pela classe derivada.
    active=true;
  }
}

class Program{

	static void Main(){
	
    Car car1=new Car("Beautiful",120);

    Console.WriteLine("Nome.......: {0}",car1.name);
    Console.WriteLine("Vel.Máxima.: {0}",car1.getSpeedMax());
    Console.WriteLine("Ligado.....: {0}",car1.getActive());
	
	}
}