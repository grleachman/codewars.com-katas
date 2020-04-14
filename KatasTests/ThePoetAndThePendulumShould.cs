using Kata1;
using Shouldly;
using Xunit;

namespace KatasTheorys
{
    public class ThePoetAndThePendulumShould
    {

        [Theory]
        [InlineData(new[] { 4, 10, 9 }, new[] { 10, 4, 9 })]
        [InlineData(new[] { 8, 7, 10, 3 }, new[] { 8, 3, 7, 10 })]
        [InlineData(new[] { 6, 6, 8, 5, 10 }, new[] { 10, 6, 5, 6, 8 })]
        [InlineData(new[] { 9, 4, 6, 4, 10, 5 }, new[] { 9, 5, 4, 4, 6, 10 })]
        [InlineData(new[] { 4, 6, 8, 7, 5 }, new[] { 8, 6, 4, 5, 7 })]
        [InlineData(new[] { 10, 5, 6, 10 }, new[] { 10, 5, 6, 10 })]
        [InlineData(new[] { 11, 12, 12 }, new[] { 12, 11, 12 })]
        public void CheckShortlengthPositives(int[] values, int[] expected)
        {
            ThePoetAndThePendulum.Pendulum(values).ShouldBe(expected);
        }
        [Theory]
        [InlineData(new[] { 27, 27, 19, 21, 22, 28, 24 }, new[] { 28, 27, 22, 19, 21, 24, 27 })]
        [InlineData(new[] { 20, 19, 25, 16, 19, 30, 18, 24 }, new[] { 25, 20, 19, 16, 18, 19, 24, 30 })]
        [InlineData(new[] { 22, 26, 21, 27, 24, 21, 15, 26, 25 }, new[] { 27, 26, 24, 21, 15, 21, 22, 25, 26 })]
        [InlineData(new[] { 19, 30, 16, 19, 28, 26, 28, 17, 21, 17 }, new[] { 28, 26, 19, 17, 16, 17, 19, 21, 28, 30 })]
        [InlineData(new[] { 27, 28, 26, 28, 24, 22, 18, 16, 15, 24 }, new[] { 28, 26, 24, 18, 15, 16, 22, 24, 27, 28 })]
        [InlineData(new[] { 17, 26, 15, 26, 26, 20, 16, 18, 15 }, new[] { 26, 26, 18, 16, 15, 15, 17, 20, 26 })]
        [InlineData(new[] { 22, 21, 19, 27, 18, 15, 24, 24 }, new[] { 24, 22, 19, 15, 18, 21, 24, 27 })]
        public void CheckMediumlengthPositives(int[] values, int[] expected)
        {
            ThePoetAndThePendulum.Pendulum(values).ShouldBe(expected);
        }
        [Theory]
        [InlineData(new[] { 33, 38, 38, 36, 43, 48, 32, 40, 47, 50, 33 }, new[] { 50, 47, 40, 38, 33, 32, 33, 36, 38, 43, 48 })]
        [InlineData(new[] { 49, 40, 41, 41, 39, 43, 40, 46, 30, 47, 46, 40 }, new[] { 47, 46, 41, 40, 40, 30, 39, 40, 41, 43, 46, 49 })]
        [InlineData(new[] { 48, 41, 38, 35, 50, 46, 38, 42, 37, 49, 44, 32, 37 }, new[] { 50, 48, 44, 41, 38, 37, 32, 35, 37, 38, 42, 46, 49 })]
        [InlineData(new[] { 49, 30, 39, 30, 40, 44, 43, 48, 47, 50, 42, 48, 33 }, new[] { 50, 48, 47, 43, 40, 33, 30, 30, 39, 42, 44, 48, 49 })]
        [InlineData(new[] { 48, 43, 35, 47, 39, 38, 38, 46, 49, 32, 42 }, new[] { 49, 47, 43, 39, 38, 32, 35, 38, 42, 46, 48 })]
        public void ChecklengthyPositives(int[] values, int[] expected)
        {
            ThePoetAndThePendulum.Pendulum(values).ShouldBe(expected);
        }
        [Theory]
        [InlineData(new[] { -9, -2, -10, -6 }, new[] { -6, -10, -9, -2 })]
        [InlineData(new[] { -3, -6, -7 }, new[] { -3, -7, -6 })]
        [InlineData(new[] { -7, -8, -2, -3, -4 }, new[] { -2, -4, -8, -7, -3 })]
        [InlineData(new[] { -8, -8, -9, -10, -10, -3 }, new[] { -8, -9, -10, -10, -8, -3 })]
        [InlineData(new[] { -7, -10, -1, -10, -8 }, new[] { -1, -8, -10, -10, -7 })]
        [InlineData(new[] { -6, -2, -5 }, new[] { -2, -6, -5 })]
        public void CheckShortlengthNegatives(int[] values, int[] expected)
        {
            ThePoetAndThePendulum.Pendulum(values).ShouldBe(expected);
        }
        [Theory]
        [InlineData(new[] { -2, -11, -6, -11, -4, -3, -5 }, new[] { -2, -4, -6, -11, -11, -5, -3 })]
        [InlineData(new[] { -19, -9, -5, -6, -15, -16, -5, -12 }, new[] { -5, -9, -15, -19, -16, -12, -6, -5 })]
        [InlineData(new[] { -18, -2, -11, -10, -6, -7, -7, -12, -16 }, new[] { -2, -7, -10, -12, -18, -16, -11, -7, -6 })]
        [InlineData(new[] { -10, -10, -12, -13, -5, -10, -4, -17, -5, -12 }, new[] { -5, -10, -10, -12, -17, -13, -12, -10, -5, -4 })]
        public void CheckMediumlengthNegatives(int[] values, int[] expected)
        {
            ThePoetAndThePendulum.Pendulum(values).ShouldBe(expected);
        }
        [Theory]
        [InlineData(new[] { -33, -21, -6, -29, -24, -5, -50, -42, -43, -17, -17 }, new[] { -5, -17, -21, -29, -42, -50, -43, -33, -24, -17, -6 })]
        [InlineData(new[] { -4, -50, -32, -23, -47, -44, -43, -24, -29, -44, -20, -35 }, new[] { -20, -24, -32, -43, -44, -50, -47, -44, -35, -29, -23, -4 })]
        [InlineData(new[] { -36, -38, -44, -47, -41, -27, -10, -30, -22, -11, -23, -50, -23 }, new[] { -10, -22, -23, -30, -38, -44, -50, -47, -41, -36, -27, -23, -11 })]
        public void ChecklengthyNegatives(int[] values, int[] expected)
        {
            ThePoetAndThePendulum.Pendulum(values).ShouldBe(expected);
        }
        [Theory]
        [InlineData(new[] { -15, 8, 11 }, new[] { 11, -15, 8 })]
        [InlineData(new[] { 8, -1, -1, -10 }, new[] { -1, -10, -1, 8 })]
        [InlineData(new[] { -8, 15, 8, -3, -11 }, new[] { 15, -3, -11, -8, 8 })]
        [InlineData(new[] { 15, 17, 3, -20, -1, 3 }, new[] { 15, 3, -20, -1, 3, 17 })]
        [InlineData(new[] { -8, -13, -19, -8, 7, 15, -10 }, new[] { 15, -8, -10, -19, -13, -8, 7 })]
        [InlineData(new[] { 11, -16, -18, 13, -11, -12, 3, 18 }, new[] { 13, 3, -12, -18, -16, -11, 11, 18 })]
        [InlineData(new[] { 7, -5, -20, 15, 2, 10, 18, 4, -10 }, new[] { 18, 10, 4, -5, -20, -10, 2, 7, 15 })]
        [InlineData(new[] { -6, 1, 2, 12, 19, 12, 19, -10, 13, 1 }, new[] { 19, 12, 2, 1, -10, -6, 1, 12, 13, 19 })]
        public void CheckMixtureOfPositivesAndNegatives(int[] values, int[] expected)
        {
            ThePoetAndThePendulum.Pendulum(values).ShouldBe(expected);
        }
    }

    public class RomanNumeralsDecoder
    {
        [Theory]
        [InlineData(2008, "MMVIII")]
        [InlineData(1666, "MDCLXVI")]
        [InlineData(1990, "MCMXC")]
        [InlineData(990, "CMXC")]
        [InlineData(21, "XXI")]
        [InlineData(79, "LXXIX")]
        [InlineData(73, "LXXIII")]
        [InlineData(57, "LVII")]
        [InlineData(287, "CCLXXXVII")]
        [InlineData(3888, "MMMDCCCLXXXVIII")]

        [InlineData(1000, "M")]
        [InlineData(500, "D")]
        [InlineData(100, "C")]
        [InlineData(50, "L")]
        [InlineData(48, "XLVIII")]
        [InlineData(10, "X")]
        [InlineData(5, "V")]
        [InlineData(1, "I")]
        public void Test(int expected, string roman)
        {
            RomanDecode.Solution(roman).ShouldBe(expected);
        }
    }
}
