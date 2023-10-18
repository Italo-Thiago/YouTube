// Classes e Objetos

using System;

public class Jogador{
    public int energy=100;
    public bool alive=true;
  }
class Program{
	static void Main(){
    // Desta forma e possível instancia um novo objeto da classe Jogador.
    // o comando "new" reserva na memória RAM um endereço para o objeto.
    Jogador j1=new Jogador();
    Jogador j2=new Jogador();
    Jogador j3=new Jogador();
    j1.energy=50;
    Console.WriteLine("Energia do jogador 1: {0}",j1.energy);
    Console.WriteLine("Energia do jogador 2: {0}",j2.energy);
	}
}