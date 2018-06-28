using System;

namespace ConvertAge
{
    class Program
    {
        public enum AgeType { Cat = 1, Dog, Human }

        public static int ConvertAge(int petAge, AgeType ageType)
        {
            int convertAge = 0;
            switch (ageType)
            {
                case AgeType.Cat:
                    {
                        convertAge = ConvertCatToHuman(petAge);
                        break;
                    }

                case AgeType.Dog:
                    {
                        convertAge = ConvertToDog(petAge);
                        break;
                    }
                case AgeType.Human:
                    {
                        Console.WriteLine("Not available.");
                        break;
                    }
            }

            return convertAge;
        }

        public static int ConvertCatToHuman(int petAge)
        {
            int humanAge = 0;

            if (petAge >= 1)
            {
                humanAge += 15;
            }
            if (petAge >= 2)
            {
                humanAge += 9;
            }
            if (petAge >= 3)
            {
                humanAge += (petAge - 2) * 4;
            }
            return humanAge;
        }

        public static int ConvertToDog(int petAge)
        {
            int humanAge = 0;

            if (petAge >= 1)
            {
                humanAge += 16;
            }
            if (petAge >= 2)
            {
                humanAge += 8;
            }
            if (petAge >= 3)
            {
                humanAge += (petAge - 2) * 5;
            }
            return humanAge;
        }


        static void Main(string[] args)
        {
            while (true)
            {
                int usersPetType = MainMenu.GetPetType();
                if (usersPetType == 0)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                int petAge = MainMenu.ChoosePetAge();
                int convertAge = ConvertAge(petAge, (AgeType)usersPetType);
                Console.WriteLine($"Your pet's age is equal to {convertAge} human's years");
                Console.WriteLine("Press any key to proceed with a new pet");
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
