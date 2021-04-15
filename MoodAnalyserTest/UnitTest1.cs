using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser;
using System;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void whenMood_IsSad_ShouldReturnSad()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.analyseMood("I am in sad Mood");
            Assert.AreEqual("SAD", mood);
        }
        [TestMethod]
        public void whenMood_IsHappy_ShouldReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.analyseMood("I am in happy Mood");
            Assert.AreEqual("HAPPY", mood);
        }
    }
}
