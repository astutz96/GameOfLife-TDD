using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        /* Game Of Life Rules
         * Any live cell with fewer than two live neighbours dies.
         * Any live cell with two or three live neighbours lives.
         * Any live cell with more than three live neighbours dies.
         * Any dead cell with exactly three live neighbours become a live cell
         */

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}