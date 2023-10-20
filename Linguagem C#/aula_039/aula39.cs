// Classes e métodos abstratos

using System;

abstract class Vehicle{// Classe base abstrata
	protected int speedMax;
	protected int speedCurrent;
	protected int active;
	public Vehicle(){
		active=false;
		speedCurrent=0;
	} 
}

class Program{

	static void Main(){
	
		Vehicle veiculo = new Vehicle();	
	
	}
}
