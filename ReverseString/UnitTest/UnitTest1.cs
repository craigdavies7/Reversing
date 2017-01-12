using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseString.Models;
using ReverseString;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Sentence s = new Sentence();
        WordReverse wReverse = new WordReverse();

        [TestMethod]
        public void ReverseWordsFromSentence_HappyPath()
        {
            s.enteredWords = "hello world";
            var result = wReverse.reverseWords(s.enteredWords);

            Assert.AreEqual("world hello", result);
        }

        [TestMethod]
        public void ReverseWordsFromSentence_SadPath1()
        {
            s.enteredWords = "Hello World";
            var result = wReverse.reverseWords(s.enteredWords);

            Assert.AreNotEqual("Hello World", result);
        }

        [TestMethod]
        public void ReverseWordsFromSentence_SadPath2()
        {
            s.enteredWords = "Hello World";
            var result = wReverse.reverseWords(s.enteredWords);

            Assert.AreNotEqual("WorldHellow", result);
        }

        [TestMethod]
        public void ReverseLettersFromWord_HappyPath()
        {
            s.enteredWords = "Hello World";
            var result = wReverse.reverseWordLetters(s.enteredWords);

            Assert.AreEqual("dlroW olleH", result);
        }
        
        [TestMethod]
        public void ReverseLettersFromWord_SadPath()
        {
            s.enteredWords = "Hello World";
            var result = wReverse.reverseWordLetters(s.enteredWords);

            Assert.AreNotEqual("Hello World", result);
        }


    }
}
