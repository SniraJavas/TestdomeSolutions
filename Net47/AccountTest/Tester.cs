// Using only NUnit's Assert.AreEqual method, write tests for the Account class that cover the following cases:
//  - The Deposit and Withdraw methods will not accept negative numbers.
//  - Account cannot overstep its overdraft limit.
//  - The Deposit and Withdraw methods will deposit or withdraw the correct amount, respectively.
//  - The Withdraw and Deposit methods return the correct results.

using NUnit.Framework;

[TestFixture]
public class Tester
{
    private double epsilon = 1e-6;

    [Test]
    public void AccountCannotHaveNegativeOverdraftLimit()
    {
        Account account = new Account(-20);

        Assert.AreEqual(0, account.OverdraftLimit, epsilon);
    }

    [Test]
    public void DepositCannotHaveNegativeNumbers()
    {
        Account account = new Account(0);
        Assert.IsFalse(account.Deposit(-20));
    }

    [Test]
    public void WithdrawCannotHaveNegativeNumbers()
    {
        Account account = new Account(0);
        Assert.IsFalse(account.Withdraw(-20));
    }

    [Test]
    public void DepositReturnTheCorrectResults()
    {
        Account account = new Account(0);
        Assert.IsTrue(account.Deposit(20));
    }

    [Test]
    public void WithdrawReturnTheCorrectResults()
    {
        Account account = new Account(20);
        Assert.IsTrue(account.Withdraw(5));
    }

    [Test]
    public void AccountCannotOverstepItsOverdraftLimit()
    {
        Account account = new Account(-10);
        Assert.IsFalse(account.Withdraw(11));
    }

    [Test]
    public void DepositCorrectAmountRespectively()
    {
        Account account = new Account(0);
        account.Deposit(20);
        Assert.AreEqual(20, account.Balance, epsilon);
    }

    [Test]
    public void WithdrawCorrectAmountRespectively()
    {
        Account account = new Account(10);
        account.Withdraw(10);
        Assert.AreEqual(-10, account.Balance, epsilon);
    }
}