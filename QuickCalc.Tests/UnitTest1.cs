using QuickCalc.Core;
using Xunit;

namespace QuickCalc.Tests;

public class UnitTest1
{
        [Fact] public void Add_8_5_Returns_13() => Assert.Equal(13, Calculator.Add(8, 5));
        [Fact] public void Subtract_16_7_Returns_9() => Assert.Equal(9, Calculator.Subtract(16, 7));
        [Fact] public void Multiply_4_5_Returns_20() => Assert.Equal(20, Calculator.Multiply(4, 5));
        [Fact] public void Divide_9_3_Returns_3() => Assert.Equal(3, Calculator.Divide(9, 3));
        [Fact] public void Divide_ByZero_Throws() => Assert.Throws<DivideByZeroException>(() => Calculator.Divide(5, 0));
        [Fact] public void Add_Negatives_Works() => Assert.Equal(-15, Calculator.Add(-8, -7));
        [Fact] public void Divide_Decimals_Works() => Assert.Equal(2.5, Calculator.Divide(5, 2), 10);
        [Fact] public void Multiply_LargeNumbers_Works() =>Assert.Equal(1_000_000_000_000, Calculator.Multiply(1_000_000, 1_000_000));
    
}
