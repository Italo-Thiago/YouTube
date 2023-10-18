// Enumeradores (enum)

using System;

class Program{

  enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
	static void Main(){
	
    DiasSemana ds = DiasSemana.Domingo;
    DiasSemana ds = (DiasSemana)1;
    int ds = (int)DiasSemana.Sexta;

    Console.WriteLine(ds);
	
	}
}