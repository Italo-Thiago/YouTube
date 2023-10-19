// Public vs Private

using System;

class Program{
  class Jogador{
    // Private cria um nível de proteção nas variáveis de objetos.
    private int energy;
    private string name;
    public Jogador(string name){
      this.name=name;
      energy=100;
    }
    public int getEnergy(){
      return energy;
    }
    public string getName(){
      return name;
    }
    // "set" e usado quando queremos dizer que um valor será modificado, geralmente usado com "get" na nomenclaturas de métodos
    public void setEnergy(int e){
      if(e<0){
        // Aqui existe uma pegadinha clássica da matemática (-) com (-) igual a (+), ou seja, a lógica apresentada neste "if" deve ser somar e não subtrair.
        if(energy+e < 0){
          energy=0;
        }else{
          energy+=e;
        }
      }else if(e>0){
        if(energy+e > 100){
          energy=100;
        }else{
          energy+=e;
        }
      }
    }
  }
  // "get" e o nome dado quando queremos obter um certo valor.
  
	static void Main(){
    Jogador j1=new Jogador("Italo");

    j1.setEnergy(30);

    Console.WriteLine("Nome...: {0}",j1.getName());
    Console.WriteLine("Energia: {0}",j1.getEnergy());
	
	}
}