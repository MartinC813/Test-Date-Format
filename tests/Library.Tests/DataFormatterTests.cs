using TestDateFormat;

namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestFormatoVacio()
    {
        const string date = ""; 
        Assert.IsEmpty(date, DateFormatter.ChangeFormat(date));
    }
    [Test]
    public void TestFormatoCorrecto()
    {
        const string date = "10/11/1997";
        const string fechaConvertida = "1997-11-10";
        Assert.AreEqual(fechaConvertida, DateFormatter.ChangeFormat(date)); 
    }
    
    [Test]
    public void TestFormatoIncorrecto()
    {
        const string date = "1997-11-15";
        const string fechaConvertida = "";
        Assert.AreEqual(fechaConvertida, DateFormatter.ChangeFormat(date));
    }
    
}