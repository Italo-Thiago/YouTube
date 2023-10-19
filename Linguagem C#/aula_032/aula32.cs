// This

using System;

class Program{
	
  class Calculos{
    public int v1;
    public int v2;
    public Calculos(int v1, int v2){
      // Quando "this." e usado ele referencia a variável com mesmo nome porem no escopo da classe, ou seja, no exemplo abaixo os dois valores são igualados.
      this.v1=v1;
      this.v2=v2;
    }
    public int Somar(){
      return v1+v2;
    }
  }

	static void Main(){
  
    Calculos c=new Calculos(10,2);

    Console.WriteLine(c.Somar());
	}
}