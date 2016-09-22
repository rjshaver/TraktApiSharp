﻿namespace TraktApiSharp.Tests.Experimental.Requests.Base.Post.Bodyless
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Experimental.Requests.Base;
    using TraktApiSharp.Experimental.Requests.Base.Post.Bodyless;
    using TraktApiSharp.Experimental.Requests.Interfaces;

    [TestClass]
    public class ATraktSingleItemBodylessPostRequestTests
    {
        [TestMethod]
        public void TestATraktSingleItemBodylessPostRequestIsAbstract()
        {
            typeof(ATraktSingleItemBodylessPostRequest<>).IsAbstract.Should().BeTrue();
        }

        [TestMethod]
        public void TestATraktSingleItemBodylessPostRequestIsSubclassOfATraktSingleItemRequest()
        {
            typeof(ATraktSingleItemBodylessPostRequest<int>).IsSubclassOf(typeof(ATraktSingleItemRequest<int>)).Should().BeTrue();
        }

        [TestMethod]
        public void TestATraktSingleItemBodylessPostRequestHasGenericTypeParameter()
        {
            typeof(ATraktSingleItemBodylessPostRequest<>).ContainsGenericParameters.Should().BeTrue();
            typeof(ATraktSingleItemBodylessPostRequest<int>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(1);
        }

        [TestMethod]
        public void TestATraktSingleItemBodylessPostRequestImplementsITraktRequestInterface()
        {
            typeof(ATraktSingleItemBodylessPostRequest<>).GetInterfaces().Should().Contain(typeof(ITraktRequest));
        }
    }
}
