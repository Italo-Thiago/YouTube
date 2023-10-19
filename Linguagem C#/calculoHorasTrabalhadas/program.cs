using System;

class Program{

	static void Main(){
  int escolha=0;

	int horaIni=0;
  int horaEnd=0;
  int horaAlmo=0;

  int cargaHora=0;
  double sal=0.000F;
  double horaValor=0.000F;

  Console.WriteLine("Escolha a opção de calculo: ");
  Console.WriteLine("Escolha [0]: Horas trabalhadas.");
  Console.WriteLine("Escolha [1]: Valor da sua hora de trabalho");
  escolha = Convert.ToInt32(Console.ReadLine());

  if (escolha == 0){
    Console.Clear();

    Console.WriteLine("Digite o horário que você começa a trabalhar: (Formato: 00)");
    horaIni = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o horário de saída do trabalho: (Formato: 00)");
    horaEnd = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o tempo de almoço: (Formato: 00)");
    horaAlmo = Convert.ToInt32(Console.ReadLine());

    int horasTrab = (horaEnd - horaIni) - horaAlmo;
    Console.Write("O total de horas trabalhadas em um dia é: {0}",horasTrab);
  } else if (escolha == 1) {
    Console.Clear();

    Console.WriteLine("Digite sua carga horária semanal: (Formato: 00)");
    cargaHora = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite seu salário: (Formato: 0.000)");
    sal = Convert.ToDouble(Console.ReadLine());

    horaValor = ((cargaHora * 4) / sal) * 100;

    Console.WriteLine(horaValor.ToString("C",new System.Globalization.CultureInfo("pt-BR")));
  }else {
    Console.WriteLine("Programa encerrado...");
  }
	
	}
}