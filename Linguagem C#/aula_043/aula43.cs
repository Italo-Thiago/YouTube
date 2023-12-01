// Interface

using System;

public interface Vehicle{
  // A interface não aceita declaração de variáveis.
  // bool active;
  void active();
  void disable();
  void info();
}
public interface Combat{
  void shot();
}
// Usando duas interfaces.
class Car:Vehicle,Combat{
  private bool active;
  private int ammunation;
  public Car(){
    setAmmunation(100);
  }
  public void setAmmunation(int qtde){
    this.ammunation=qtde;
  }
  public void active(){
    this.active=true;
  }
  public void disable(){
    this.active=false;
  }
  public void shot(){

  }
  public void info(){}
}
class Program{

	static void Main(){
	
    Car c1=new Car();
	
	}
}
