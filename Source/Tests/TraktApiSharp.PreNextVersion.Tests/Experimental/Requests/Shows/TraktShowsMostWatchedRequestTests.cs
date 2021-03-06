﻿namespace TraktApiSharp.Tests.Experimental.Requests.Shows
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Enums;
    using TraktApiSharp.Experimental.Requests.Shows;
    using TraktApiSharp.Objects.Get.Shows.Common;
    using TraktApiSharp.Requests;

    [TestClass]
    public class TraktShowsMostWatchedRequestTests
    {
        [TestMethod, TestCategory("Requests"), TestCategory("Shows"), TestCategory("Lists")]
        public void TestTraktShowsMostWatchedRequestIsNotAbstract()
        {
            typeof(TraktShowsMostWatchedRequest).IsAbstract.Should().BeFalse();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Shows"), TestCategory("Lists")]
        public void TestTraktShowsMostWatchedRequestIsSealed()
        {
            typeof(TraktShowsMostWatchedRequest).IsSealed.Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Shows"), TestCategory("Lists")]
        public void TestTraktShowsMostWatchedRequestIsSubclassOfATraktShowsMostPWCRequest()
        {
            typeof(TraktShowsMostWatchedRequest).IsSubclassOf(typeof(ATraktShowsMostPWCRequest<TraktMostWatchedShow>)).Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Shows"), TestCategory("Lists")]
        public void TestTraktShowsMostWatchedRequestHasAuthorizationNotRequired()
        {
            var request = new TraktShowsMostWatchedRequest(null);
            request.AuthorizationRequirement.Should().Be(TraktAuthorizationRequirement.NotRequired);
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Shows"), TestCategory("Lists")]
        public void TestTraktShowsMostWatchedRequestHasValidUriTemplate()
        {
            var request = new TraktShowsMostWatchedRequest(null);
            request.UriTemplate.Should().Be("shows/watched{/period}{?extended,page,limit,query,years,genres,languages,countries,runtimes,ratings,certifications,networks,status}");
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Shows"), TestCategory("Lists")]
        public void TestTraktShowsMostWatchedRequestUriParamsWithoutPeriod()
        {
            var request = new TraktShowsMostWatchedRequest(null);
            var uriParams = request.GetUriPathParameters();

            uriParams.Should().NotBeNull().And.BeEmpty();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Shows"), TestCategory("Lists")]
        public void TestTraktShowsMostWatchedRequestUriParamsWithUnspecifiedPeriod()
        {
            var period = TraktTimePeriod.Unspecified;

            var request = new TraktShowsMostWatchedRequest(null)
            {
                Period = period
            };

            var uriParams = request.GetUriPathParameters();

            uriParams.Should().NotBeNull().And.BeEmpty();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Shows"), TestCategory("Lists")]
        public void TestTraktShowsMostWatchedRequestUriParamsWithPeriod()
        {
            var period = TraktTimePeriod.Monthly;

            var request = new TraktShowsMostWatchedRequest(null)
            {
                Period = period
            };

            var uriParams = request.GetUriPathParameters();

            uriParams.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(1);
            uriParams.Should().Contain("period", period.UriName);
        }
    }
}
