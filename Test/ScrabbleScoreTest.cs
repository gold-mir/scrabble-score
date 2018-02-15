using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application.Models;

namespace Application.Tests
{
    [TestClass]
    public class ScrabbleScoreTest
    {
        [TestMethod]
        public void GetScore_ReturnsScore()
        {
            Assert.AreEqual(ScrabbleScore.GetScore('a'), 1);
            Assert.AreEqual(ScrabbleScore.GetScore('d'), 2);
            Assert.AreEqual(ScrabbleScore.GetScore('b'), 3);
            Assert.AreEqual(ScrabbleScore.GetScore('f'), 4);
            Assert.AreEqual(ScrabbleScore.GetScore('k'), 5);
            Assert.AreEqual(ScrabbleScore.GetScore('j'), 8);
            Assert.AreEqual(ScrabbleScore.GetScore('z'), 10);
        }

        [TestMethod]
        public void GetScore_ReturnsZeroForNonLetter()
        {
            Assert.AreEqual(ScrabbleScore.GetScore('8'), 0);
            Assert.AreEqual(ScrabbleScore.GetScore('.'), 0);
        }

        [TestMethod]
        public void GetScore_IsCaseInsensitive()
        {
            Assert.AreEqual(ScrabbleScore.GetScore('f'), ScrabbleScore.GetScore('F'));
        }
        [TestMethod]
        public void GetWordScore_ReturnsScore()
        {
            Assert.AreEqual(ScrabbleScore.GetWordScore("potato"), 8);
            Assert.AreEqual(ScrabbleScore.GetWordScore("zoo"), 12);
        }
        [TestMethod]
        public void GetWordScore_ReturnsScoreIgnoringNonLetter()
        {
            Assert.AreEqual(ScrabbleScore.GetWordScore("catastrophe"), ScrabbleScore.GetWordScore("cat#ast!roph##$$(3)e"));
        }
        [TestMethod]
        public void GetWordScore_IsCaseInsensitive()
        {
            Assert.AreEqual(ScrabbleScore.GetWordScore("TRAIN"), ScrabbleScore.GetWordScore("train"));
        }
    }
}
