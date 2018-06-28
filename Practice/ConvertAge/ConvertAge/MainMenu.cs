using System;

namespace ConvertAge
{
    public class MainMenu
    {
        public static int ChoosePetAge()
        {
            Console.Clear();
            int outputPetAge = 0;
            int outputStringPetAge = 0;
            while (true)
            {
                Console.WriteLine("Write your pet's age!");
                try
                {
                    outputStringPetAge = Convert.ToInt32(Console.ReadLine());   
                }

                catch (FormatException)
                {
                    Console.WriteLine("Incorrect value!");
                    continue;
                }

                if (outputStringPetAge >= 0 && outputStringPetAge < 30)
                {
                    outputPetAge = outputStringPetAge;
                    break;
                }
                else
                {
                    Console.WriteLine("Write the right age!");
                }
            }
            return outputPetAge;
        }

        public static int GetPetType()
        {
            int outputType = 0;
            int inputType = 0;
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Choose pet's type:\r\n" +
                                  "1 - Cat\r\n" +
                                  "2 - Dog\r\n" +
                                  "0 - Quit\r\n" +
                                  "Your answer:");
                try
                {
                    inputType = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Incorrect value!");
                    continue;
                }

                if (inputType >=0 && inputType <= 2)
                {
                    outputType = inputType;
                    break;
                }
            }
            return outputType;
        }
    }
}
