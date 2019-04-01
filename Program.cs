using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listen
{
	class Program
	{
		static void Main(string[] args)
		{
			// deklarieren
			List<Int32> t_ges = new List<Int32>();
			List<Int32> t_dreier = new List<Int32>();
			List<Int32> t_fünfer = new List<Int32>();
			List<Int32> t_siebener = new List<Int32>();
			List<string> t_quer = new List<string>();
			List<Int32> t_end = new List<Int32>();

			// Gesamten Zahlenbereich erzeugen
			for (int i = 9999; i < 99999; i++)
			{
				t_ges.Add(i);
			}
			// Listen mit Dreierreihe erzeugen
			for (int i = 10002; i < 99999; i+=3)
			{
				t_dreier.Add(i);
			}
			// Listen mit Fünferreihe erzeugen
			for (int i = 10000; i < 99999; i+=5)
			{
				t_fünfer.Add(i);
			}
			// Listen mit Siebenerreihe erzeugen
			for (int i = 10003; i < 99999; i+=7)
			{
				t_siebener.Add(i);
			}

			//for (int i = 10000; i < 99999; i++)
			//{
			//	(((i[0] + i[1] + i[2]+ i[3]) % 7 )== i[4])
				
			//}
			// listen vergleichen
			var result = t_ges.Except(t_dreier).ToList();
			result = result.Except(t_fünfer).ToList();
			result = result.Except(t_siebener).ToList();
			// zweiter Teil
			
			foreach (var item in result)
			{
				var buff = Convert.ToString(result);
				t_quer.Add(buff);
				
			}

			//foreach (var item in t_quer)
			//{
				
			//	Console.Write(item);
				//if (!(((buff[0] + buff[1] + buff[2]+ buff[3]) % 7 )== buff[4]))
				//{
				//	t_quer.Remove(buff);
				//}

			//}


			// Ausgeben
			Console.WriteLine("TestLineA");
			Console.WriteLine(t_ges.Count);
			Console.WriteLine(t_dreier.Count);
			Console.WriteLine(t_fünfer.Count);
			Console.WriteLine(t_siebener.Count);
			Console.WriteLine(result.Count);
			Console.WriteLine(t_quer.Count);
			Console.WriteLine(t_end.Count);
			//foreach (var item in t_end)
			//{
			//	Console.Write(item + " ");
			//	Console.WriteLine("TestLineB");

			//}
			Console.WriteLine();
			Console.ReadKey();

		}
	}
}
