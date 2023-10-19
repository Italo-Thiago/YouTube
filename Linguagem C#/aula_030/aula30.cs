// Sobrecarga de Construtores

using System;

class Program{

	public class Jogador{
    public int energy;
    public bool alive;
    public string nome;
    public  Jogador(){
      energy=100;
      alive=false;
      nome="Jogador";
    }
    public Jogador(string n){
      energy=100;
      alive=true;
      nome=n;
    }
    public Jogador(string n, int e){
      energy=e;
      alive=true;
      nome=n;
    }
    public Jogador(string n,int e,bool v){
      energy=e;
      alive=v;
      nome=n;
    }
    public void info(){
      Console.WriteLine("Nome jogador....:{0}",nome);
      Console.WriteLine("Energia jogador.:{0}",energy);
      Console.WriteLine("Estado jogador..:{0}\n",alive);
    }
  }
	static void Main(){
    
    Jogador j1=new Jogador();
    Jogador j2=new Jogador("Italo");
    Jogador j3=new Jogador("Thiago",200);
    Jogador j4=new Jogador("Silva",0,false);

    j1.info();
    j2.info();
    j3.info();
    j4.info();
  }
}