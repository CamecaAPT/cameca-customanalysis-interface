using NUnit.Framework;

namespace Cameca.CustomAnalysis.Interface.Tests;

public class IonFormulaTests
{
	[SetUp]
	public void Setup()
	{
	}

	[Test]
	public void IonFormulaComponentHashEqualsTest()
	{
		var x = new IonFormula.Component("Cu", 1);
		var y = new IonFormula.Component("Cu", 1);
		var xHash = x.GetHashCode();
		var yHash = y.GetHashCode();
		Assert.AreEqual(xHash, yHash);
	}

	[Test]
	public void IonFormulaHashEqualsTest()
	{
		var x = new IonFormula(new[] { new IonFormula.Component("Cu", 1) });
		var y = new IonFormula(new[] { new IonFormula.Component("Cu", 1) });
		var xHash = x.GetHashCode();
		var yHash = y.GetHashCode();
		Assert.AreEqual(xHash, yHash);
	}

	[Test]
	public void IonFormulaEqualsTest()
	{
		var x = new IonFormula(new[] { new IonFormula.Component("Cu", 1) });
		var y = new IonFormula(new[] { new IonFormula.Component("Cu", 1) });
		Assert.AreEqual(x, y);
	}

	[Test]
	public void IonFormulaEqualsOperatorTest()
	{
		var x = new IonFormula(new[] { new IonFormula.Component("Cu", 1) });
		var y = new IonFormula(new[] { new IonFormula.Component("Cu", 1) });
		Assert.IsTrue(x == y);
	}

	[Test]
	public void IonFormulaNotEqualsNameTest()
	{
		var x = new IonFormula(new[] { new IonFormula.Component("Cu", 1) });
		var y = new IonFormula(new[] { new IonFormula.Component("O", 1) });
		Assert.AreNotEqual(x, y);
	}

	[Test]
	public void IonFormulaNotEqualsOperatorNameTest()
	{
		var x = new IonFormula(new[] { new IonFormula.Component("Cu", 1) });
		var y = new IonFormula(new[] { new IonFormula.Component("O", 1) });
		Assert.IsTrue(x != y);
	}

	[Test]
	public void IonFormulaNotEqualsCountTest()
	{
		var x = new IonFormula(new[] { new IonFormula.Component("O", 1) });
		var y = new IonFormula(new[] { new IonFormula.Component("O", 2) });
		Assert.AreNotEqual(x, y);
	}

	[Test]
	public void IonFormulaNotEqualsOperatorCountTest()
	{
		var x = new IonFormula(new[] { new IonFormula.Component("O", 1) });
		var y = new IonFormula(new[] { new IonFormula.Component("O", 2) });
		Assert.IsTrue(x != y);
	}

	[Test]
	public void IonFormulaToStringNoSingleNumeral()
	{
		var formula = new IonFormula(new[] { new IonFormula.Component("O", 1) });
		Assert.AreEqual(formula.ToString(), "O");
	}

	[Test]
	public void IonFormulaToStringWithNumeral()
	{
		var formula = new IonFormula(new[] { new IonFormula.Component("O", 2) });
		Assert.AreEqual(formula.ToString(), "O2");
	}

	// If no carbon: All alphabetically
	[Test]
	public void IonFormulaToStringAlphabetical()
	{
		var formula = new IonFormula(new[] { new IonFormula.Component("O", 1), new IonFormula.Component("Al", 1) });
		Assert.AreEqual(formula.ToString(), "AlO");
	}

	// If carbon present: Carbon, Hydrogen, then all other alphabetically
	[Test]
	public void IonFormulaToStringCarbon()
	{
		var formula = new IonFormula(new[] { new IonFormula.Component("Al", 1), new IonFormula.Component("C", 1) });
		Assert.AreEqual(formula.ToString(), "CAl");
	}

	[Test]
	public void IonFormulaToStringCarbonHydrogen()
	{
		var formula = new IonFormula(new[]
		{
			new IonFormula.Component("Al", 1),
			new IonFormula.Component("C", 1),
			new IonFormula.Component("H", 1),
			new IonFormula.Component("F", 1),
			new IonFormula.Component("Ts", 1),
		});
		Assert.AreEqual(formula.ToString(), "CHAlFTs");
	}
}
