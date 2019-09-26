using System;
using Xunit;
using ReachHelpWF.Models;

namespace ReachHelpWFUnitTest
{
    
    public class LanguageModelTest
    {
        [Theory]
        [InlineData("Rice", "2", "ಅಕ್ಕಿ", true)]
        [InlineData("Rice", "2", "ಅಕ್ಕಿ", false)]
        [InlineData("Wheat", "2", "ಗೋಧಿ", true)]
        [InlineData("Sugar", "2", "ಸಕ್ಕರೆ", true)]
        public void CheckLanguageInsertion(string englishWord, string languageId, string languageWord,bool expected)
        {
            LanguageModel languageTest = new LanguageModel();
            bool actual = languageTest.LanguageTranslation(englishWord, languageId, languageWord);

            Assert.Equal(expected, actual);

        }
    }
}
