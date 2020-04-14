using Kata1;
using System;
using Xunit;

namespace KatasTests
{
    public class DuplicateEncoderShould
    {
        [Fact]
        public void BasicTests1()
        {
            Assert.Equal("(((", DuplicateEncoder.DuplicateEncode("din"));
        }

        [Fact]
        public void BasicTests2()
        {
            Assert.Equal("()()()", DuplicateEncoder.DuplicateEncode("recede"));
        }

        [Fact]
        public void BasicTestsCaseInsensitive()
        {
            Assert.Equal(")())())", DuplicateEncoder.DuplicateEncode("Success"));
        }

        [Fact]
        public void BasicTests4()
        {
            Assert.Equal("))((", DuplicateEncoder.DuplicateEncode("(( @"));
        }
    }
}
