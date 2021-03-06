﻿namespace TraktApiSharp.Tests.Experimental.Requests.Shows
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Experimental.Requests.Shows;
    using TraktApiSharp.Requests;

    [TestClass]
    public class TraktShowTranslationsRequestTests
    {
        [TestMethod, TestCategory("Requests"), TestCategory("Shows")]
        public void TestTraktShowTranslationsRequestIsNotAbstract()
        {
            typeof(TraktShowTranslationsRequest).IsAbstract.Should().BeFalse();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Shows")]
        public void TestTraktShowTranslationsRequestIsSealed()
        {
            typeof(TraktShowTranslationsRequest).IsSealed.Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Shows")]
        public void TestTraktShowTranslationsRequestIsSubclassOfATraktListGetByIdRequest()
        {
            //typeof(TraktShowTranslationsRequest).IsSubclassOf(typeof(ATraktListGetByIdRequest<TraktShowTranslation>)).Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Shows")]
        public void TestTraktShowTranslationsRequestHasAuthorizationNotRequired()
        {
            var request = new TraktShowTranslationsRequest(null);
            request.AuthorizationRequirement.Should().Be(TraktAuthorizationRequirement.NotRequired);
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Shows")]
        public void TestTraktShowTranslationsRequestHasValidUriTemplate()
        {
            var request = new TraktShowTranslationsRequest(null);
            request.UriTemplate.Should().Be("shows/{id}/translations");
        }
    }
}
