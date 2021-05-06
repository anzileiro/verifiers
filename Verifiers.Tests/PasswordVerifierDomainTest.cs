using System;
using Xunit;
using Verifiers.Domain;

namespace Verifiers.Tests
{
    public class PasswordVerifierDomainTest
    {
        [Theory]
        [InlineData("AbTp9!fok")]
        [InlineData("ycTp9$fuk")]
        [InlineData("xbTw9@cok")]
        public void CheckIfPasswordMatchesAllVerifiers(string value)
        {
            new Password(value).Validate();
        }

        [Theory]
        [InlineData("AbT p9!fok")]
        [InlineData("ycTp9$aaa")]
        [InlineData("abc")]
        public void CheckIfPasswordDoesNotMatchVerifiers(string value)
        {
            Assert.Throws<Exception>(() => new Password(value).Validate());
        }
    }
}
