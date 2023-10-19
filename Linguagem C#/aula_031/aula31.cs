// Classes static

using System;

class Program{

	static public class Jogador{
		static int energy;
		static bool alive;
		static string nome;

		static public void iniciar(string n){
			energy=100;
			alive=false;
			nome=n;
		}

		static public void info(){
			Console.WriteLine("Nome jogador....:{0}",nome);
			Console.WriteLine("Energia jogador.:{0}",energy);
			Console.WriteLine("Estado jogador..:{0}\n",alive);
		}
	}

	class Inimigo{
		static public bool alert;
		public string name;
		public Inimigo(string n){
			alert=false;
			name=n;
		}
		public void info(){
			Console.WriteLine(name);
			Console.WriteLine(alert);
			Console.WriteLine("----------------------------");
		}
	}

	static void Main(){
		Jogador.iniciar("Italo");
		Jogador.info();

		Inimigo i1=new Inimigo("Doido");
		Inimigo i2=new Inimigo("Maluco");
		Inimigo i3=new Inimigo("Pirado");

		// Perceba que ao modificar somente um parâmetro da Classe "Inimigo" todos mudam seu valor para "true" isso ocorre por que alert e um parâmetro "static", ou seja, na memória o valor "true" e estático portanto fixo.
		Inimigo.alert=true;

		i1.info();
		i2.info();
		i3.info();
	}
}