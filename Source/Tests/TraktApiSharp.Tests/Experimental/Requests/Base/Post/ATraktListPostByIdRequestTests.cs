﻿namespace TraktApiSharp.Tests.Experimental.Requests.Base.Post
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Experimental.Requests.Base.Post;
    using TraktApiSharp.Experimental.Requests.Interfaces;

    [TestClass]
    public class ATraktListPostByIdRequestTests
    {
        [TestMethod, TestCategory("Requests"), TestCategory("Base"), TestCategory("Post")]
        public void TestATraktListPostByIdRequestIsAbstract()
        {
            typeof(ATraktListPostByIdRequest<,>).IsAbstract.Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Base"), TestCategory("Post")]
        public void TestATraktListPostByIdRequestIsSubclassOfATraktListPostRequest()
        {
            typeof(ATraktListPostByIdRequest<int, float>).IsSubclassOf(typeof(ATraktListPostRequest<int, float>)).Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Base"), TestCategory("Post")]
        public void TestATraktListPostByIdRequestHasGenericTypeParameter()
        {
            typeof(ATraktListPostByIdRequest<,>).ContainsGenericParameters.Should().BeTrue();
            typeof(ATraktListPostByIdRequest<int, float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(2);
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Base"), TestCategory("Post")]
        public void TestATraktListPostByIdRequestImplementsITraktHasRequestBodyInterface()
        {
            typeof(ATraktListPostByIdRequest<int, float>).GetInterfaces().Should().Contain(typeof(ITraktHasRequestBody<float>));
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Base"), TestCategory("Post")]
        public void TestATraktListPostByIdRequestImplementsITraktHasIdInterface()
        {
            typeof(ATraktListPostByIdRequest<,>).GetInterfaces().Should().Contain(typeof(ITraktHasId));
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Base"), TestCategory("Post")]
        public void TestATraktListPostByIdRequestImplementsITraktObjectRequestInterface()
        {
            typeof(ATraktListPostByIdRequest<,>).GetInterfaces().Should().Contain(typeof(ITraktObjectRequest));
        }
    }
}
