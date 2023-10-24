using SOS_Game;

namespace TestSOS
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(2)]
        public void TestBoardSize(int value)
        {
            Form1 form = new Form1();
            if (value < 3)
            {
                Assert.Throws<ArgumentException>(() => form.resizeBoard(value));
            }
        }

        [Fact]
        public void TestGameMode()
        {
            Form1 form = new Form1();
            string expected = "Simple";
            Assert.Equal(form.getGameMode(), expected);
        }
    }
}