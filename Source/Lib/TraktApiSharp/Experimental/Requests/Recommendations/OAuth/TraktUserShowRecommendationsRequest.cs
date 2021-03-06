﻿namespace TraktApiSharp.Experimental.Requests.Recommendations.OAuth
{
    using Objects.Get.Shows;

    internal sealed class TraktUserShowRecommendationsRequest : ATraktUserRecommendationsRequest<TraktShow>
    {
        public override string UriTemplate => "recommendations/shows{?extended,limit}";

        public override void Validate() { }
    }
}
