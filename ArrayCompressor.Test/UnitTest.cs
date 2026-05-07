using Xunit;

using static ArrayCompressor.Program;

namespace ArrayCompressor.Test
{
   public class Tests
   {
      public static IEnumerable<string[]> CorrectTestData =>
         [
            [ "[1, 1, 2, 2, 3]", "1, 2, 3" ],
            [ "[0, 0, 1, 1, 0]", "0, 1, 0" ],
            [ "[-1, -1, -1, 2, -1, -1, 3]", "-1, 2, -1, 3" ],
            [ "[]", "" ]
         ];

      public static IEnumerable<object[]> InCorrectTestData =>
         [
            [ "]" ],
            [ "a" ],
            [ "[a, -1, -1, 2, -1, -1, 3]" ],
            [ "[1 2 3]" ],
            [ "]" ],
            [ "" ],
         ];

      [Theory]
      [MemberData(nameof(CorrectTestData))]
      public void CorrectProcessing(string input, string expected) => Assert.Equal(expected, ProcessingInput(input));

      [Theory]
      [MemberData(nameof(InCorrectTestData))]
      public void InCorrectProcessing(string input) => Assert.Equal("Incorrect input", ProcessingInput(input));

      [Fact]
      public void EmptyArrayCompressor() => Assert.Equal([], CompressArray([]));

      [Fact]
      public void NullArrayCompressor() => Assert.Equal([], CompressArray(null!));
   }
}
