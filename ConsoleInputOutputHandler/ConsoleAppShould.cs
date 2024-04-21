using ConsoleAppTesting;
namespace ConsoleInputOutputHandler
{
    [TestClass]
    public class ConsoleAppShould
    {
        /*[TestMethod]
        public void ReturnEmptyStringConst()
        {
            //Arrange
            string input = "";
            string expectedOutput = "Вы ввели пустую строку" +
                Environment.NewLine;
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader(input));
            Console.SetOut(output);
            //Act
            Program.Main(new string[] { });
            //Assert
            Assert.AreEqual(expectedOutput, output.ToString());
        }
        [TestMethod]
        public void ReturnStringItselfWhenNotEmpty()
        {
            //Arrange
            string input = "abc" + Environment.NewLine + "abc";
            string expectedOutput = input + Environment.NewLine;
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader(input));
            Console.SetOut(output);
            //Act
            Program.Main(new string[] { });
            //Assert
            Assert.AreEqual(expectedOutput, output.ToString());
        }*/
        [TestMethod]
        public void GetUserInput_3and4_ExpectedEnterError()
        {
            //arrange
            string input = "5\n";
            int expectedOutput = 5;
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader(input));
            Console.SetOut(output);

            //act
            int userInput = Program.GetUserInput("testNumber");

            //assert
            Assert.AreEqual(expectedOutput, userInput);
        }

        [TestMethod]
        public void CreateMatrix_3and4_ExpectedRightMatix()
        {
            //arrange
            int x = 3; int y = 4;
            string expectedOutput = "1 2 3 " + 
                Environment.NewLine + "2 4 6 " +
                Environment.NewLine + "3 6 9 " +
                Environment.NewLine + "4 8 12 " +
                Environment.NewLine;

            //act
            string actual = Program.CreateMatrix(x, y);

            //assert
            Assert.AreEqual(expectedOutput, actual, "Матрицы совпадают!");
        }
    }
}