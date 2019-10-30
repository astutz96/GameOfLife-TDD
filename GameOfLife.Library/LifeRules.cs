using System;

namespace GameOfLife.Library
{
    public enum CellState
    {
        Alive, Dead,
    }
    public class LifeRules
    {
        public static CellState GetNewState(CellState currentState, int liveNeighbors)
        {
            ValidateCellState(currentState);
            ValidateLiveNeighborsCount(liveNeighbors);
            
            switch (currentState)
            {
                case CellState.Alive:
                    if (liveNeighbors < 2 || liveNeighbors > 3)
                        return CellState.Dead;
                    break;
                case CellState.Dead:
                    if (liveNeighbors == 3)
                        return CellState.Alive;
                    break;
            }
            return currentState;
        }

        private static void ValidateCellState(CellState currentState)
        {
            if (!Enum.IsDefined(typeof(CellState), currentState))
                throw new ArgumentOutOfRangeException(nameof(currentState));
        }

        private static void ValidateLiveNeighborsCount(int liveNeighbors)
        {
            if (liveNeighbors > 8 || liveNeighbors < 0)
                throw new ArgumentOutOfRangeException(nameof(liveNeighbors));
        }
    }
}
