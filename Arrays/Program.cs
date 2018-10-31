using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colorOptions = { "Red", "Espresso", "White", "Navy" };

            var brownIndex = Array.IndexOf(colorOptions, "Espresso");

            colorOptions.SetValue("Blue", 3);

            for (int i = 0; i < colorOptions.Length; i++)
            {
                colorOptions[i] = colorOptions[i].ToLower();
            }

            foreach (var color in colorOptions)
            {
                Console.WriteLine($"The color is {color}");
            }
        }
    }
}
