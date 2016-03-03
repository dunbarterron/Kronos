﻿using Kronos.Core.Command;
using Kronos.Core.Communication;
using Kronos.Core.Requests;
using Kronos.Core.Serialization;
using Moq;
using Xunit;

namespace Kronos.Core.Tests.Command
{
    public class GetCommandTests
    {
        [Fact]
        public void ExecuteReturnsCorrectValue()
        {
            byte[] value = SerializationUtils.Serialize("lorem ipsum");
            var request = new GetRequest("masterKey");

            var communicationServiceMock = new Mock<IClientServerConnection>();
            communicationServiceMock.Setup(x => x.SendToServer(request)).Returns(value);

            GetCommand command = new GetCommand(communicationServiceMock.Object, request);

            byte[] response = command.Execute();

            Assert.Equal(response, value);
            communicationServiceMock.Verify(x => x.SendToServer(It.IsAny<GetRequest>()), Times.Exactly(1));
        }
    }
}