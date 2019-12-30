using System;

namespace Quiz
{
	class Program
	{
		static void Main(string[] args)
		{
			bool exit = false;
			string MenuSelection;
			int Sum, Number1, Number2;
			int Score = 0;
			int[] Answers;
			Random rand = new Random();

			Console.WriteLine("Witaj w moim quizie matematycznym");
			Console.WriteLine("Wciśnij 1 żeby otrzymać pytanie");
			Console.WriteLine("Wciśnij 2 żeby wyjść z gry");

			while (!exit)
			{
				MenuSelection = Console.ReadLine();

				if(MenuSelection == "1")
				{
					Number1 = rand.Next(0, 100);
					Number2 = rand.Next(0, 100);
					Sum = Number1 + Number2;
					Answers = new int[4];

					for (int i = 0; i < Answers.Length; i++)
					{
						Answers[i] = rand.Next(0, 200);
					}

					Answers[rand.Next(0, 3)] = Sum;

					Console.WriteLine("Wciśniej a,b,c lub d aby zaznaczyć odpowiedź");
					//Console.WriteLine(Number1 + "+" + Number2 + "= X");				(Brzydko ale szybko)
					//Console.WriteLine($"{Number1}+{Number2}=X");						(Poprawna wersja)
					Console.WriteLine(string.Format("{0}+{1}=X", Number1, Number2));    //(Także poprawna wersja)
					Console.WriteLine("Podaj odpowiedź:");
					Console.WriteLine($"A){Answers[0]} B){Answers[1]} C){Answers[2]} D){Answers[3]}");
					
					bool isAnswerCorrect = false;
					bool ChoiseOver = false;

					while (!ChoiseOver)
					{
						if (Console.ReadLine() == "a")
						{
							isAnswerCorrect = Answers[0] == Sum;
							ChoiseOver = true;
						}
						else if (Console.ReadLine() == "b")
						{
							isAnswerCorrect = Answers[0] == Sum;
							ChoiseOver = true;
						}
						else if (Console.ReadLine() == "c")
						{
							isAnswerCorrect = Answers[0] == Sum;
							ChoiseOver = true;
						}
						else if (Console.ReadLine() == "d")
						{
							isAnswerCorrect = Answers[0] == Sum;
							ChoiseOver = true;
						}
						else
						{
							Console.WriteLine("Musisz wpisać odpowiedź");
						}
					}

					if (isAnswerCorrect== true)
					{
						Console.WriteLine("Odpowiedź jest poprawna, gratuluje zdobywasz punkt");
						Score = Score + 1;
					}
					else if (isAnswerCorrect == false)
					{
						Console.WriteLine("Ospowiedź jest niepoprawna, przykro mi");
					}

					Console.WriteLine($"Twoja obecna ilośc punktów to {Score}");
					Console.WriteLine("Wciśnij 1 żeby otrzymać pytanie");
					Console.WriteLine("Wciśnij 2 żeby wyjść z gry");
				}
				else if (MenuSelection == "2")
				{
					exit = true;
				}
				else 
				{
					Console.WriteLine("Podałeś złe dane wejścia, proszę wpisać jedną z opcji menu i kliknąć enter");
				}
			}
		}
	}
}
