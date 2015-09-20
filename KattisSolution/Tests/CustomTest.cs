using System.IO;
using System.Text;
using NUnit.Framework;

namespace KattisSolution.Tests
{
    [TestFixture]
    [Category("sample")]
    public class CustomTest
    {
        [Test]
        public void SampleTest_WithStringData_Should_Pass()
        {
            // Arrange
            const string expectedAnswer = "3.14159265358979 0\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("1.0 1 0\n0 0 0\n")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }
    }
}
