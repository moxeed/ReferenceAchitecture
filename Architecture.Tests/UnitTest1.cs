using _0._Architecture.Domain;
using NetArchTest.Rules;

namespace Architecture.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            var result = Types.InCurrentDomain()
                 .That().ImplementInterface(typeof(IEntity))
                 .Should().ResideInNamespaceContaining("Entity")
                 .And().BePublic()
                 .GetResult();

            Assert.True(result.IsSuccessful);
        }
    }
}