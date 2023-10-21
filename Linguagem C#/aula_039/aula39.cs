// Classes e métodos abstratos

using System;

abstract class Vehicle{// Classe base abstrata
	protected int speedMax;
	protected int speedCurrent;
	protected bool active;
	public Vehicle(){
		active=false; 
		speedCurrent=0;
	} 
	public void setLigado(bool active){
		this.active=active;
	}
	public int getSpeedCurrent(){
		return speedCurrent;
	}
	abstract public void acceleration(int mult);
}

class Car:Vehicle{
	public Car(){
		speedMax=120;
	}
    public override void acceleration(int mult){
			speedCurrent+=10*mult;
		}
}

class Program{

	static void Main(){
	
		Car car1=new Car();

		car1.acceleration(10);
		car1.acceleration(-5);

		Console.WriteLine(car1.getSpeedCurrent());
	}
}
