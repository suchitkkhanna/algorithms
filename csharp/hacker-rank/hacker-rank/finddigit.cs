using System;
using System.Collections.Generic;


namespace hacker_rank
{
    internal class FindDigit
    {
        static void Main(string[] args)
        {
            string numberOfInputs = Console.ReadLine();

            if (String.IsNullOrEmpty(numberOfInputs))
                return;

            numberOfInputs = numberOfInputs.Trim();

            int number;

            if (!int.TryParse(numberOfInputs, out number) || number == 0)
                return;

            var results = new List<int>();

            while (number > 0)
            {
                int count = 0;

                string line = Console.ReadLine();

                if (string.IsNullOrEmpty(line)) return;

                int inputNumber;

                if (!int.TryParse(line, out inputNumber)) return;

                int temp = inputNumber;
                while (temp > 0)
                {
                    int digit = temp % 10;

                    if (digit != 0 && inputNumber % digit == 0)
                    {
                        count++;
                    }
                    temp = temp / 10;
                }

                number--;

                results.Add(count);
            }

            foreach (var result in results)
                Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
