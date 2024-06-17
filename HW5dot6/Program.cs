using HW5dot6;

internal class Program
{
	private static void Main(string[] args)
	{
		(string Name, string LastName, int Age, bool HasPet, int PetCount, string[]? PetsNames, int FavColoursCount, string[] FavColours) User = GetUserData.GetData();

		Console.WriteLine();

		WriteUserData.WriteData(User.Name, User.LastName, User.Age, User.HasPet, User.PetCount, User.PetsNames, User.FavColoursCount, User.FavColours);
	}
}