using NUnit.Framework;
using Altom.AltUnityDriver;

public class NewAltUnityTest
{
    public AltUnityDriver altUnityDriver;
    //Before any test it connects with the socket
    [OneTimeSetUp]
    public void SetUp()
    {
        altUnityDriver =new AltUnityDriver();
    }

    //At the end of the test closes the connection with the socket
    [OneTimeTearDown]
    public void TearDown()
    {
        altUnityDriver.Stop();
    }

    [Test]
    public void IntegratedTest()
    {
        altUnityDriver.LoadScene("Menu");
        altUnityDriver.FindObject(By.NAME, "Skin Button").Click();
        var skin = altUnityDriver.WaitForObject(By.NAME, "Panel Skins");
        Assert.IsTrue(skin.enabled);
        altUnityDriver.FindObject(By.NAME, "Exit Button Skins").Click();
        var menu = altUnityDriver.WaitForObject(By.NAME, "Panel Menu Principal");
        Assert.IsTrue(menu.enabled);
        altUnityDriver.FindObject(By.NAME, "Play Button").Click();
        altUnityDriver.WaitForCurrentSceneToBe("Escenarios");

        altUnityDriver.Stop();
    }

    [Test]
    public void SkinTest()
    {
        altUnityDriver.LoadScene("Menu");
        altUnityDriver.FindObject(By.NAME, "Skin Button").Click();
        var menu = altUnityDriver.WaitForObject(By.NAME, "Panel Menu Principal");
        var skin = altUnityDriver.WaitForObject(By.NAME, "Panel Skins");
        Assert.IsTrue(skin.enabled);
    }

    [Test]
    public void EscenariosTest()
    {
        altUnityDriver.LoadScene("Menu");
        altUnityDriver.FindObject(By.NAME, "Play Button").Click();
        altUnityDriver.WaitForCurrentSceneToBe("Escenarios");
    }

}