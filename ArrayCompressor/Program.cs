namespace ArrayCompressor;

public class Program
{
   public  static int[] CompressArray(int[] input)
   {
      if (input == null || input.Length == 0) return [];

      List<int> inputDistinct = [];

      inputDistinct.Add(input[0]);

      for (int i = 1; i < input.Length; i++)
         if (input[i] != inputDistinct[^1]) inputDistinct.Add(input[i]);

      return [.. inputDistinct];
   }

   public static string ProcessingInput(string input)
   {
      if (string.IsNullOrEmpty(input) || !input.StartsWith('[') || !input.EndsWith(']')) return "Incorrect input";

      if (input == "[]") return "[]";

      int?[] inputSplit = input.Trim('[', ']', ' ').Split(',').Select(x => int.TryParse(x, out int z) ? z : (int?)null).ToArray();

      if (inputSplit.Any(x => x == (int?)null)) return "Incorrect input";

#pragma warning disable CS8629 // Проверка выполняется шагом ранее.
      return '[' + string.Join(", ", CompressArray([.. inputSplit.Select(x => (int)x.Value)])) + ']';
#pragma warning restore CS8629 // Тип значения, допускающего NULL, может быть NULL.
   }

   static void Main()
   {
      Console.WriteLine(@"Send array -> [-1, 0, 0, 1, 1, -1]
or
Send `exit` to close program");

      string _input = Console.ReadLine() ?? string.Empty;

      while (!_input.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
      {
         Console.WriteLine(ProcessingInput(_input));
         _input = Console.ReadLine() ?? string.Empty;
      }
   }
}
