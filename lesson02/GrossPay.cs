//asking and getting the wage
Console.Write("What is your hourly rate? ");
string input1 = Console.ReadLine() ?? "";
decimal rate = decimal.Parse(input1);


//asking and getting how many hours worked
Console.Write("How many hours did you work? ");
string input2 = Console.ReadLine() ?? "";
decimal hours = decimal.Parse(input2);

//do the math to calculate gross pay
decimal grossPay = rate * hours;

//tell user their gross pay
Console.WriteLine($"Gross pay is: {grossPay:C}");