// Console.WriteLine("Please enter the team size, it must be between 9 and 15 members");

// int teamSize = int.Parse(Console.ReadLine() ?? "");

// while (teamSize < 9 || teamSize > 15)
// {
//   Console.WriteLine("The size you gave is invalild with our restrictions, please try again: ");
//   teamSize = int.Parse(Console.ReadLine() ?? "");
// }



Console.WriteLine("Please enter the team size, it must be between 9 and 15 members");
int teamSize = int.Parse(Console.ReadLine() ?? "");

do
{
  Console.WriteLine("Enter team size between 9 and 15: ");
  teamSize = int.Parse(Console.ReadLine() ?? "");
  if (teamSize < 9 || teamSize > 15)
  {
    Console.WriteLine("Invaild value. Dont do it again :(");
  }
} while (teamSize < 9 || teamSize > 15);
