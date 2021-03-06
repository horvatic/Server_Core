﻿using System;
using Server.Core;
using Xunit;

namespace Server.Test
{
    public class PoolDataForRequestTest
    {
        [Fact]
        public void Make_Not_Null_Pool_Data_For_Request()
        {
            Assert.NotNull(
                new PoolDataForRequest(new HttpResponse(new MockZSocket()),
                new MockZSocket(),
                Guid.NewGuid()));
        }

        [Fact]
        public void Make_Class_Returns_Socket_And_GID()
        {
            var socket = new MockZSocket();
            var response = new HttpResponse(socket);
            var id = Guid.NewGuid();

            var poolRequestData =
                new PoolDataForRequest(response, socket, id);

            Assert.Equal(response, poolRequestData.Response);
            Assert.Equal(socket, poolRequestData.Handler);
            Assert.Equal(id, poolRequestData.Id);
        }
    }
}