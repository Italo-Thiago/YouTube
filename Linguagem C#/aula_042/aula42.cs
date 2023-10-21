// Indexadores de Classes.

using System;

class Car{
  private int[] speedMax=new int[5]{80,120,160,240,300};
  public int this[int i]{
    get{
      return speedMax[i];
    }
    set{
      if(value < 0){
        speedMax[i]=0;
      }else if(value>300){
        speedMax[i]=300;
      }else{
        speedMax[i]=value;
      }
    }
  }
  public Car(){

  }
}
class Program{

	static void Main(){
	
    Car c1=new Car();

    c1[4]=200;
    Console.WriteLine("Velocidade: {0}",c1[4]);
	}
}