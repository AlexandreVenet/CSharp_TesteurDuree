namespace CSharp_TesteurDuree
{
	internal class Program
	{
		static void Main(string[] args)
		{
			TesteurDuree x = new();

			EcrireEnCouleur($"Date de début : {x.ObtenirTamponHoraireString()}\n", ConsoleColor.DarkGray);

			x.Demarrer();



			Task.Delay(2000).Wait();



			x.Arreter();

			Console.WriteLine(x.ObtenirInfoDuree());

			EcrireEnCouleur($"\nDate de fin : {x.ObtenirTamponHoraireString()}", ConsoleColor.DarkGray);

			Console.Read();
		}

		private static void EcrireEnCouleur(string texte, ConsoleColor couleur)
		{
			Console.ForegroundColor = couleur;
			Console.WriteLine(texte);
			Console.ResetColor();
		}
	}
}
