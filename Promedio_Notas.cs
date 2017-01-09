using System;

namespace Promedio_Notas
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double Nota = 0.00D;
			int Aux = -1;
			int i = 0;
			char P = 'y';

			while (Aux != 0) 
			{
				Console.WriteLine ("Ingrese la nota: ");
				Aux = Convert.ToInt16(Console.ReadLine());
				Nota = Nota + Aux;
				i= ++i;


				if (Aux == 0)
				{
					Console.Write ("Desea incluir la nota 0...? (y/n): ");
					P = Convert.ToChar(Console.ReadLine());
					Aux = Aux++;

					if (P == 'n')
						i = --i;
				}
			}
			Nota = Nota / i;
			Console.WriteLine ("\nLa nota promedio es: "+Nota);
			Console.WriteLine ("\nPulse una tecla para salir.");
			Console.ReadKey();
		}
	}
}
