﻿namespace TraktApiSharp.Tests.Experimental.Requests.Base.Post
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Experimental.Requests.Base;
    using TraktApiSharp.Experimental.Requests.Base.Post;
    using TraktApiSharp.Experimental.Requests.Interfaces;

    [TestClass]
    public class ATraktListPostByIdRequestTests
    {
        [TestMethod]
        public void TestATraktListPostByIdRequestIsAbstract()
        {
            typeof(ATraktListPostByIdRequest<,>).IsAbstract.Should().BeTrue();
        }

        [TestMethod]
        public void TestATraktListPostByIdRequestIsSubclassOfATraktListRequest()
        {
            typeof(ATraktListPostByIdRequest<int, float>).IsSubclassOf(typeof(ATraktListRequest<int>)).Should().BeTrue();
        }

        [TestMethod]
        public void TestATraktListPostByIdRequestHasGenericTypeParameter()
        {
            typeof(ATraktListPostByIdRequest<,>).ContainsGenericParameters.Should().BeTrue();
            typeof(ATraktListPostByIdRequest<int, float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(2);
        }

        [TestMethod]
        public void TestATraktListPostByIdRequestImplementsITraktRequestInterface()
        {
            typeof(ATraktListPostByIdRequest<,>).GetInterfaces().Should().Contain(typeof(ITraktRequest));
        }

        [TestMethod]
        public void TestATraktListPostByIdRequestImplementsITraktHasRequestBodyInterface()
        {
            typeof(ATraktListPostByIdRequest<int, float>).GetInterfaces().Should().Contain(typeof(ITraktHasRequestBody<float>));
        }

        [TestMethod]
        public void TestATraktListPostByIdRequestImplementsITraktHasIdInterface()
        {
            typeof(ATraktListPostByIdRequest<,>).GetInterfaces().Should().Contain(typeof(ITraktHasId));
        }
    }
}
