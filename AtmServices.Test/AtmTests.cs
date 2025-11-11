namespace AtmServices.Test;
using AtmServices;
public class AtmTests
{
    Atm testAtm;
    int initialBalance = 100;
    public AtmTests() {
        testAtm = new Atm(initialBalance);
    }

    [Fact]
    public void Test1()
    {

    }
    [Fact]
    public void Test_Withdraw()
    {
        var result = testAtm.withdraw(25);
        Assert.True(result);
        Assert.Equal(75, testAtm.getBalance());
    }
    [Fact]
    public void Test_Withdraw_Zero()
    {
        var result = testAtm.withdraw(101);
        Assert.False(result);
        Assert.Equal(100, testAtm.getBalance());
    }
    [Fact]
    public void Test_Deposit()
    {
        var result = testAtm.deposit(40);
        Assert.True(result);
        Assert.Equal(140, testAtm.getBalance());
    }
    [Fact]
    public void Test_Deposit_Negative()
    {
        var result = testAtm.deposit(-1);
        Assert.False(result);
        Assert.Equal(100, testAtm.getBalance());
    }
}