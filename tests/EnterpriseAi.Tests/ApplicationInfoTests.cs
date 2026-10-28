using EnterpriseAi.Console;

namespace EnterpriseAi.Tests;

public class ApplicationInfoTests
{
    [Fact]
    public void GetWelcomeMessage_ReturnsExpectedMessage()
    {
        // Arrange
        const string expected = "Enterprise AI .NET Lab is ready!";

        // Act
        string actual = ApplicationInfo.GetWelcomeMessage();

        // Assert
        Assert.Equal(expected, actual);
    }
}
