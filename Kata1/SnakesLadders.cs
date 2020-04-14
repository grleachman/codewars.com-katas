using System.Collections.Generic;
using System.Diagnostics;

namespace Kata1
{
    public class SnakesLadders
    {
        internal class GameState
        {
            internal bool finished;
            internal int player;
            internal Dictionary<int, int> map = new Dictionary<int, int>()
            {
                [2] = 38,
                [7] = 14,
                [8] = 31,
                [15] = 26,
                [16] = 6,
                [21] = 42,
                [28] = 84,
                [36] = 44,
                [46] = 25,
            };
            internal int[] position;

            public GameState()
            {
                finished = false;
                position = new[] { 0, 0 };
                player = 0;
            }

            internal int board(int nextPosition)
            {
                if (!map.TryGetValue(nextPosition, out var mappedPosition))
                {
                    return nextPosition;
                }
                return mappedPosition;
            }
        }

        private GameState _gameState = new GameState();
        public string play(int die1, int die2)
        {
            if (_gameState.finished)
            {
                return "Game Over!";
            }

            var isDouble = (die1 == die2);
            var dieTotal = die1 + die2;

            // game play (probably in separate method);

            var currentPlayer = _gameState.player;
            var startPosition = _gameState.position[currentPlayer];
            var nextPosition = startPosition + dieTotal;
            var modifiedPosition = _gameState.board(nextPosition);
            _gameState.position[currentPlayer] = modifiedPosition;

            // clean

            if (modifiedPosition == 100)
            {
                _gameState.finished = true;
                return $"Player {currentPlayer + 1} Wins!";
            }

            if (!isDouble)
            {
                _gameState.player = (_gameState.player + 1) % 2;
            }


            return $"Player {currentPlayer + 1} is on square {modifiedPosition}";
        }
    }
}
