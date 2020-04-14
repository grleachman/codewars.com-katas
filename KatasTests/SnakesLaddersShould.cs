using Kata1;
using Xunit;

namespace KatasTheorys
{
    public class SnakesLaddersShould
    {
        private SnakesLadders Theory = new SnakesLadders();

        [Fact]
        public void Player1On38()
        {
            string result = Theory.play(1, 1);
            Assert.Equal("Player 1 is on square 38", result);
        }

        [Fact]
        public void Player1On44()
        {
            string result = Theory.play(1, 1);
            result = Theory.play(1, 5);
            Assert.Equal("Player 1 is on square 44", result);
        }

        [Fact]
        public void Player2On31()
        {
            string result = Theory.play(1, 1);
            result = Theory.play(1, 5);
            result = Theory.play(6, 2);
            Assert.Equal("Player 2 is on square 31", result);
        }

        [Fact]
        public void Player1On25()
        {
            string result = Theory.play(1, 1);
            result = Theory.play(1, 5);
            result = Theory.play(6, 2);
            result = Theory.play(1, 1);
            Assert.Equal("Player 1 is on square 25", result);
        }
    }
}
