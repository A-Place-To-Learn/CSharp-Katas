using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.MonthChecker.Tests
{
    [TestClass]
    public class ConsoleOutputTests
    {
        private string GetConsoleTextAfterInput(string input)
        {
            string consoleResult;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (var sr = new StringReader($"{input}{Environment.NewLine}"))
                {
                    Console.SetIn(sr);

                    Program.Main(new string[] { });

                    consoleResult = sw.ToString();
                }
            }

            return consoleResult;
        }

        [TestMethod]
        public void ItShouldProvideUserWithMessageToInsertInput()
        {
            var expected = "Please enter the month in numerical value (1-12)";

            var result = GetConsoleTextAfterInput("");

            Assert.IsTrue(result.Contains(expected));
        }

        [TestMethod]
        public void ItShouldReturnMessageWhenInputIsNotNumberOfMonth()
        {
            var expected = "Please close the program, run the program again, and input number between 1-12";
            var consoleInput = "0";

            var result = GetConsoleTextAfterInput(consoleInput);

            Assert.IsTrue(result.Contains(expected));
        }

        [TestMethod]
        public void ItShouldContainASeasonMessageWhenMonthIsValid()
        {
            var expected = "Your month is a Winter month.";
            var consoleInput = "1";

            var result = GetConsoleTextAfterInput(consoleInput);

            Assert.IsTrue(result.Contains(expected));
        }
    }
}
