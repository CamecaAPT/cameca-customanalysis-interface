using NUnit.Framework;

namespace Cameca.CustomAnalysis.Interface.Tests;

public class IonFormulaTests
{
	[SetUp]
	public void Setup()
	{
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
}
