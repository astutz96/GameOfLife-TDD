using NUnit.Framework;
using GameOfLife.Library;

namespace Tests
{
    public class Tests
    {
        /* Game Of Life Rules
         * Any live cell with fewer than two live neighbors dies.
         * Any live cell with two or three live neighbors lives.
         * Any live cell with more than three live neighbors dies.
         * Any dead cell with exactly three live neighbors become a live cell
         */

        [Test]
        public void LiveCell_FewerThanTwoLiveneighbors_Dies([Values(0,1)] int liveNeighbors)
        {
            var currentState = CellState.Alive;

            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Dead, newState);
        }

        [Test]
        public void LiveCell_TwoOrThreeLiveNeighbors_Lives([Values(2,3)] int liveNeighbors)
        {
            var currentState = CellState.Alive;

            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Alive, newState);
        }

        [Test]
        public void LiveCell_MoreThanThreeLiveNeighbors_Dies([Range(4,8)] int liveNeighbors)
        {
            var currentState = CellState.Alive;

            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Dead, newState);
        }
        [Test]
        public void DeadCell_ExactlyThreeLiveNeighbors_Lives([Values(3)] int liveNeighbors)
        {
            var currentState = CellState.Dead;

            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Alive, newState);

        }

        [Test]
        public void DeadCell_FewerThanThreeLiveNeighbors_StaysDead([Range(0,2)] int liveNeighbors)
        {
            var currentState = CellState.Dead;

            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Dead, newState);

        }

        [Test]
        public void DeadCell_GreaterThanThreeLiveNeighbors_StaysDead([Range(4, 8)] int liveNeighbors)
        {
            var currentState = CellState.Dead;

            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Dead, newState);

        }
    }
}