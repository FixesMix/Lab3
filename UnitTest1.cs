namespace MyRootLibPowPowTest;


using Xunit;
using MyRootLibPowPow;

public class UnitTest1{
    [Fact]
	public void TestPowOf2() {
	
		double a = 4; // arrange
        double b = 2;


        double expected = 16;
		double actual = Pow.CalculatePower(a, b); // act
 
		Assert.Equal(expected, actual); // assert
	}	
	[Fact]
    public void TestPowOf3() {
    
		double a = 4; // arrange
        double b = 3;

		double expected = 64;
	
		double actual = Pow.CalculatePower(a,b); // act

		Assert.Equal(expected, actual); // assert
	} 
}