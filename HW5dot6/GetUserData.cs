using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5dot6
{
	public class GetUserData
	{
		public static (string Name, string LastName, int Age, bool HasPet, int PetCount, string[] PetsNames, int FavColoursCount, string[] FavColours) GetData()
		{
			Console.WriteLine("Введите имя");
			string Name = Console.ReadLine();

			Console.WriteLine("Введите фамилию");
			string LastName = Console.ReadLine();

			string age = "";
			while (!int.TryParse(age, out int result))
			{
				Console.WriteLine("Введите возраст пользователя");
				age = Console.ReadLine();
			}
			int Age = Int32.Parse(age);

			Console.WriteLine("Есть ли у вас животные?");
			string hasPet = "";
			while (hasPet != "Да" && hasPet != "Нет")
			{
				Console.WriteLine("Да или Нет");
				hasPet = Console.ReadLine();
			}

			bool HasPet;
			int PetCount = -1;

			if (hasPet == "Да")
			{
				HasPet = true;
			}
			else
			{
				HasPet = false;
				PetCount = 0;
			}

			if (HasPet)
			{
				string petCount = "";
				while (!int.TryParse(petCount, out int result))
				{
					Console.WriteLine("Сколько их у вас?");
					petCount = Console.ReadLine();
				}
				PetCount = Convert.ToInt32(petCount);
			}

			string[] PetsNames = new string[PetCount];
			if(PetCount > 0)
			{
				Console.WriteLine($"Введите их:");

				for (int i = 0; i < PetsNames.Length; i++)
				{
					Console.WriteLine($"Животное: {i + 1}");
					PetsNames[i] = Console.ReadLine();
				}
			}

			string favColoursCount = "";
			int FavColoursCount;
			while (!int.TryParse(favColoursCount, out int result))
			{
				Console.WriteLine("Сколько у вас любимых цветов?");
				favColoursCount = Console.ReadLine();
			}
			FavColoursCount = Convert.ToInt32(favColoursCount);

			string[] FavColours = new string[FavColoursCount];
			if (FavColoursCount > 0)
			{
				Console.WriteLine($"Введите их:");

				for (int i = 0; i < FavColours.Length; i++)
				{
					Console.WriteLine($"Цвет: {i + 1}");
					FavColours[i] = Console.ReadLine();
				}
			}

			return (Name, LastName, Age, HasPet, PetCount, PetsNames, FavColoursCount, FavColours);
		}
	}
}
