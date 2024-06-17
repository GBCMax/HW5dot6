using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5dot6
{
	public class WriteUserData
	{
		public static void WriteData(string Name, string LastName, int Age, bool HasPet, int PetCount, string[]? PetsNames, int FavColoursCount, string[] FavColours)
		{
			Console.WriteLine($"Имя: {Name}");
			Console.WriteLine();
			Console.WriteLine($"Фамилия: {LastName}");
			Console.WriteLine();
			Console.WriteLine($"Возраст: {Age}");
			Console.WriteLine();
			Console.WriteLine($"Наличие животных: {HasPet}");
			Console.WriteLine();
			if (HasPet)
			{
				Console.WriteLine($"Количество животных: {PetCount}");
				Console.WriteLine();
				Console.WriteLine("Список животных");
				Console.WriteLine();
				foreach (var pet in PetsNames)
				{
					Console.WriteLine($"{pet}");
					Console.WriteLine();
				}
			}
			Console.WriteLine($"Количество любимых цветов: {FavColoursCount}");
			Console.WriteLine();
			Console.WriteLine("Список цветов:");
			foreach (var fav in FavColours)
			{
				Console.WriteLine(fav);
				Console.WriteLine();
			}
		}
	}
}
