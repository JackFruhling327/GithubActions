namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}

[TestClass]
public class Subtraction
{
    [TestMethod]
    public void Subtract_Valid_Fruhling()
    {
        Assert.AreEqual(1, Program.Subtract("3", "2"));
        Assert.AreEqual(0, Program.Subtract("5", "5"));
        Assert.AreEqual(-2, Program.Subtract("3", "5"));
    }

    [TestMethod]
    public void Subtract_Invalid_Fruhling()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("3", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("b", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("x", "y"));
    }

    [TestMethod]
    public void Subtract_Null_Fruhling()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
    }
}

[TestClass]
public class Multiplication
{
    [TestMethod]
    public void Multiply_Valid_Fruhling()
    {
        Assert.AreEqual(6, Program.Multiply("3", "2"));
        Assert.AreEqual(0, Program.Multiply("0", "5"));
        Assert.AreEqual(-15, Program.Multiply("-3", "5"));
    }

    [TestMethod]
    public void Multiply_Invalid_Fruhling()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("3", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("foo", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("x", "y"));
    }

    [TestMethod]
    public void Multiply_Null_Fruhling()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
    }
}

[TestClass]
public class Division
{
    [TestMethod]
    public void Divide_Valid_Fruhling()
    {
        Assert.AreEqual(2, Program.Divide("6", "3"));
        Assert.AreEqual(1, Program.Divide("5", "5"));
        Assert.AreEqual(-2, Program.Divide("-10", "5"));
    }

    [TestMethod]
    public void Divide_Invalid_Fruhling()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("10", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("foo", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("bar", "baz"));
    }

    [TestMethod]
    public void Divide_Null_Fruhling()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
    }

    [TestMethod]
    public void Divide_ByZero_Fruhling()
    {
        Assert.ThrowsException<DivideByZeroException>(() => Program.Divide("5", "0"));
    }
}

[TestClass]
public class PowerTests
{
    [TestMethod]
    public void Power_Valid_Fruhling()
    {
        Assert.AreEqual(8, Program.Power("2", "3"));
        Assert.AreEqual(1, Program.Power("5", "0"));
        Assert.AreEqual(16, Program.Power("4", "2"));
    }

    [TestMethod]
    public void Power_Invalid_Fruhling()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Power("2", "x"));
        Assert.ThrowsException<FormatException>(() => Program.Power("cat", "dog"));
    }

    [TestMethod]
    public void Power_Null_Fruhling()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
    }
}