namespace FactoryPattern.Tests
{
    [TestClass]
    public class FactoryPatternTest
    {
        [TestMethod]
        public void CreateLightTheme_Document()
        {
            // Arrange
            DocumentFactory factory = new DocumentFactory();

            // Act
            Document document = factory.CreateLightTheme();

            // Assert
            Assert.AreEqual("Black", document.FontColor);
            Assert.AreEqual("White", document.BackGroundColor);
        }

        [TestMethod]
        public void CreateDarkTheme_Document()
        {
            // Arrange
            DocumentFactory factory = new DocumentFactory();

            // Act
            Document document = factory.CreateDarkTheme();

            // Assert
            Assert.AreEqual("White", document.FontColor);
            Assert.AreEqual("Black", document.BackGroundColor);
        }

        [TestMethod]
        public void CreateLightTheme_IDE()
        {
            // Arrange
            IDEFactory factory = new IDEFactory();

            // Act
            IDE ide = factory.CreateLightTheme();

            // Assert
            Assert.AreEqual("Black", ide.FontColor);
            Assert.AreEqual("White", ide.BackGroundColor);
            Assert.AreEqual("Light blue", ide.ButtonColor);
        }

        [TestMethod]
        public void CreateDarkTheme_IDE()
        {
            // Arrange
            IDEFactory factory = new IDEFactory();

            // Act
            IDE ide = factory.CreateDarkTheme();

            // Assert
            Assert.AreEqual("White", ide.FontColor);
            Assert.AreEqual("Black", ide.BackGroundColor);
            Assert.AreEqual("Light yellow", ide.ButtonColor);
        }
    }
}
