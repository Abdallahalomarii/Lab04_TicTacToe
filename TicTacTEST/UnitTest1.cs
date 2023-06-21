using Lab04_TicTacToe;
using System.Numerics;
using Xunit;
using Lab04_TicTacToe.Classes;
using System.Diagnostics;
namespace TicTacTEST
{

    public class UnitTest1
    {

        [Fact]
        public void SwitchPlayerTest()
        {
            // Arrange

            Player p1 = new Player();
            Player p2 = new Player();
            p1.Name = "p1";
            p2.Name = "p2";
            p1.IsTurn = true;
            p1.Marker = "X";
            p2.Marker = "O";
            p2.IsTurn = false;

            Game game = new Game(p1, p2);

            // Act
            game.SwitchPlayer();
            //Program.StartGame();

            // Assert
            Assert.False(p1.IsTurn);
            Assert.True(p2.IsTurn);
        }
        [Fact]
        public void TestGame_Winner()
        {
            // Arrange
            Player p1 = new Player();
            Player p2 = new Player();

            p1.IsTurn = true;
            p2.IsTurn = false;
            Game game = new Game(p1, p2);
            p1.Marker = "X";
            p2.Marker = "O";
            Board board = new Board();

            // Set up the winning condition
            board.GameBoard = new string[,]
            {
                {"X", "O", "X"},
                {"X", "O", "O"},
                {"O", "O", "X"}
            };
            game.Board = board;

            // Act
            bool result = game.CheckForWinner(game.Board);

            //Player winner = game.Play();
            // Assert
            Assert.Equal(true, result);

        }
        [Theory]
        [InlineData(1, 0, 0)] // Top Left
        [InlineData(2, 0, 1)] // Top Middle
        [InlineData(3, 0, 2)] // Top Right
        [InlineData(4, 1, 0)] // Middle Left
        [InlineData(5, 1, 1)] // Middle Middle
        [InlineData(6, 1, 2)] // Middle Right
        [InlineData(7, 2, 0)] // Bottom Left
        [InlineData(8, 2, 1)] // Bottom Middle
        [InlineData(9, 2, 2)] // Bottom Right

        public void PositionForNumber_Should_Return_Correct_Position(int position, int rows, int cols)
        {
            Position expectedPosition = new Position(rows, cols);

            // Act
            Position actualPosition = Player.PositionForNumber(position);

            // Assert
            Assert.Equal(expectedPosition.Row, actualPosition.Row);
            Assert.Equal(expectedPosition.Column, actualPosition.Column);
        }


    }
}