// Construtores e Destrutores

using System;

class Program{

	public class Jogador{
		public int energy;
		public bool alive;
		public string nome;
		// Isto abaixo e o construtor do Objeto "Jogador" que e inicializado automaticamente quando sé cria um objeto.
		public Jogador(string n){
			energy=100;
			alive=true;
			nome=n;
		}
		// Abaixo temos um destrutor que deve ser sempre precedido pelo sinal (~);
		~Jogador(){
			Console.WriteLine("Jogador {0} foi destruído",nome);
		}
	}

	static void Main(){
	
		string nome1;
		Console.Write("Digite o nome do jogador 1: ")	;
		nome1=Console.ReadLine();
  	Jogador j1=new Jogador(nome1);
		Jogador j2=new Jogador("Thiago");
	

		Console.WriteLine("Nome do jogador 1: {0}",j1.nome);
		Console.WriteLine("Nome do jogador 2: {0}",j2.nome);
	}
}