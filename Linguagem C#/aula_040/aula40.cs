// Classe Sealed

using System;
// Classes Sealed não podem ser herdadas.
sealed class Vehicle{

}
class Car:Vehicle{

}
class Program{

	static void Main(){
	// Vai dar erro porque a classe e selada.
  Car c1=new Car();

	
	}
}