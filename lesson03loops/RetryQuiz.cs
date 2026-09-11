// copy and paste code from SubtractionQuiz.cs
Random random = new();
int a = random.Next(1, 10);
int b = random.Next(1, 10);

if (a < b) 
{
  (a, b) = (b, a);
}

int correctAnswer= a - b;


Console.WriteLine($"What is {a} - {b}");
int userAnswer = int.Parse(Console.ReadLine() ?? "no input");

while (userAnswer != correctAnswer)
{
  Console.WriteLine("Insorrect. Please Try Again!");
  Console.WriteLine($"What is {a} - {b}");
  userAnswer = int.Parse(Console.ReadLine() ?? "no input");
}
Console.WriteLine("Correct!");



