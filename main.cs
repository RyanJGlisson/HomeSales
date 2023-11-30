using System;

class Program {
  public static void Main (string[] args) 
  {
      // Variables to keep track of sales totals
      int totalD = 0, totalE = 0, totalF = 0, grandTotal = 0;


      // Prompt the user for input until 'Z' or 'z' is entered
      do
      {
          Console.Write("Enter salesperson initial (D, E, F, or Z to finish): ");
          char input = Char.ToUpper(Console.ReadKey().KeyChar);
          Console.WriteLine();

          // Check if input is 'Z' to finish the loop
          if (input == 'Z')
              break;

          // Check if the input is a valid salesperson initial
          if (input != 'D' && input != 'E' && input != 'F')
          {
              Console.WriteLine("Error, invalid salesperson selected, please try again");
              continue;
          }

          // Prompt the user for the amount of sale
          Console.Write("Enter the amount of sale: ");
          int sale;
          if (int.TryParse(Console.ReadLine(), out sale))
          {
              // Update the appropriate salesperson total and the grand total
              switch (input)
              {
                  case 'D':
                      totalD += sale;
                      break;
                  case 'E':
                      totalE += sale;
                      break;
                  case 'F':
                      totalF += sale;
                      break;
              }
              grandTotal += sale;
          }
          else
          {
              Console.WriteLine("Invalid sale amount. Please enter a valid number.");
          }

      } while (true);

      // Display the results
      Console.WriteLine($"Grand Total: ${grandTotal:N0}");

      // Determine the salesperson with the highest total
      char highestSalesperson = totalD >= totalE && totalD >= totalF ? 'D' :
                                totalE >= totalD && totalE >= totalF ? 'E' :
                                'F';

      Console.WriteLine($"Highest Sale: {highestSalesperson}");

      // Wait for user input to close the console window
      Console.ReadLine();
  }
}