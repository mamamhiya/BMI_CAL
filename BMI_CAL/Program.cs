namespace BMI_CAL
{
    internal class Program
    {
        static string CalculateMaleBMI(double bmi)
        {
            if (bmi < 18.5) return "Underweight";
            else if (bmi >= 18.5 && bmi < 23.0) return "Normal";
            else if (bmi >= 23.0 && bmi < 25.0) return "Overweight";
            else if (bmi >= 25.0 && bmi < 30.0) return "Obese";
            else return "Dangerous Obese";
        }
        static string CalculateFemaleBMI(double bmi)
        {

            if (bmi < 18.5) return "Underweight)";
            else if (bmi >= 18.5 && bmi < 23.0) return "Normal";
            else if (bmi >= 23.0 && bmi < 25.0) return "Overweight";
            else if (bmi >= 25.0 && bmi < 30.0) return "Obese";
            else return "Dangerous Obese";
        }
        static void Main(string[] args)
        {
            string name = "", gender = "", Ex = "", Result = "";
            int height = 0, weight = 0;
            double BMI = 0;
            while (true)
            {

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("----------Welcome to BMI Caculate Appication--------");
                    Console.WriteLine("Please fill in your Gender ");
                    Console.Write("For Male type 'M' and for female type 'F': ");
                    gender = Console.ReadLine();
                    if (gender != "M" && gender != "F")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter 'M' for Male or 'F' for Female");
                    }
                    else
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Please enter your Name: ");
                    name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                    }
                    else if (name.Length < 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Name is too short. Please enter a valid name.");
                    }
                    else
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Please enter your Height in cm: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Height cannot be empty. Please enter a valid height.");
                        continue;
                    }

                    if (!int.TryParse(input.Trim(), out height))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid number. Please enter a numeric height in cm.");
                        continue;
                    }

                    if (height <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Height must be greater than zero. Please enter a valid height.");
                        continue;
                    }

                    break;
                }
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Please enter your Weight in kg: ");
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Weight cannot be empty. Please enter a valid weight.");
                        continue;
                    }
                    if (!int.TryParse(input.Trim(), out weight))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid number. Please enter a numeric weight in kg.");
                        continue;
                    }
                    if (weight <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Weight must be greater than zero. Please enter a valid weight.");
                        continue;
                    }
                    break;
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                BMI = weight / ((height / 100.0) * (height / 100.0));
                BMI.ToString("#.##");
                if (gender == "M")
                {
                    Result = CalculateMaleBMI(BMI);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hello Mr. " + name + " you BMI result is " + BMI + " so you that make you in " + Result + " state");
                }
                else if (gender == "F")
                {
                    Result = CalculateFemaleBMI(BMI);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hello Ms. " + name + " you BMI result is " + BMI + " so you that make you in "+  Result + " state");
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Press 'E' key to exit...");
                Ex = Console.ReadLine();
                Console.Clear();
                if (Ex == "E")
                {
                    break;
                }
            }
        }
    }
}
