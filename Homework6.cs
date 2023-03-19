/*
    // Task 41: The user enters M numbers from the keyboard. Count how many numbers greater than 0 the user entered.

    int Prompt(string message)
    {
    Console.Write(message); // Message
    string value = Console.ReadLine(); // Read a message 
    int result = Convert.ToInt32(value); // String to number
    return result;
      }

    int[] InputArray(int length)
    {
      int[] array = new int[length];
      for(int i = 0; i < array.Length; i++)
      {
        array[i] = Prompt($"Input {i+1} number: ");
      }
      return array;
    }

    void PrintArray(int[] array)
    {
      for(int i = 0; i < array.Length; i++)
      {
        Console.WriteLine($"a[{i}] = {array[i]}");
      }
    }

    int CountPositiveNumbers(int[] array)
    {
      int count = 0;
      for(int i = 0; i < array.Length; i++)
      {
        if(array[i] > 0)
        {
          count++;
        }
      }
      return count;
    }

    int length = Prompt("Input a number of elements: ");
    int[] array;
    array = InputArray(length);
    PrintArray(array);
    Console.WriteLine($"The amount of numbers above 0 is {CountPositiveNumbers(array)}");
    */
    
/*
    //Task 43: Write a program that will find the point of intersection of two lines given by the equations y = k1 * x + b1, y = k2 * x + b2; the values ​​b1, k1, b2 and k2 are set by the user.

    const int Coefficient = 0;
    const int Constant = 1;
    const int X_Coord = 0;
    const int Y_Coord = 1;
    const int Line1 = 1;
    const int Line2 = 2;
    
    double[] lineData1 = InputLineData(Line1);
    double[] lineData2 = InputLineData(Line2);

    if(ValidateLines(lineData1, lineData2))
    {
      double[] coord = FindCoords(lineData1, lineData2);
      Console.Write($"Intersection point of equations y = {lineData1[Coefficient]}*x + {lineData1[Constant]} и y = {lineData2[Coefficient]}*x + {lineData2[Constant]} ");
      Console.WriteLine($" has coordinates ({coord[X_Coord]}, {coord[Y_Coord]})");
    }
    
    //Enter a number.
    double Prompt(string message)
    {
      Console.Write(message);
      string value = Console.ReadLine();
      double result = Convert.ToDouble(value);
      return result;
    }

    //Data entry for the straight line.
    double[] InputLineData(int numberOfLine)
    {
      double[] lineData = new double[2];
      lineData[Coefficient] = Prompt($"Enter a coefficient for {numberOfLine}: ");
      lineData[Constant] = Prompt($"Enter constant for {numberOfLine} line: ");
      return lineData;
      }

      //Coordimates search.
      double[] FindCoords(double[] lineData1,double[] lineData2)
      {
        double[] coord = new double[2];
        coord[X_Coord] = (lineData1[Constant] - lineData2[Constant]) / (lineData2[Coefficient] - lineData1[Coefficient]);
        coord[Y_Coord] = lineData1[Constant] * coord[X_Coord] + lineData1[Constant];
        return coord;
      }

    bool ValidateLines(double[] lineData1, double[] lineData2)
    {
      if(lineData1[Coefficient] == lineData2[Coefficient])
      {
        if(lineData1[Constant] == lineData2[Constant])
        {
          Console.WriteLine("Lines match");
          return false;
        }
        else
        {
        Console.WriteLine("Lines are parallel");
          return false;
        }
      }
      return true;
    }
*/
