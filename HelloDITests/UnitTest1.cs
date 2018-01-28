using HelloDI;
using System;
using System.Linq;
using Xunit;
using Moq;

namespace HelloDITests
{
    public class UnitTest1
    {
        [Fact]
        public void ExclaimWillWriteCorrectMessageToMessageWriter()
        {
            var writeMock = new Mock<IMessageWriter>();
            var sut = new Salutation(writeMock.Object);

            sut.Exclaim();

            writeMock.Verify(w => w.Write("Hello DI!"));
        }
    }
}
