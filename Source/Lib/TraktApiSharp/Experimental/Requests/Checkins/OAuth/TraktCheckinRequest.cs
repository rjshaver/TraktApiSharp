﻿namespace TraktApiSharp.Experimental.Requests.Checkins.OAuth
{
    using Base.Post;

    internal sealed class TraktCheckinRequest<TItem, TRequestBody> : ATraktSingleItemPostRequest<TItem, TRequestBody>
    {
        public TraktCheckinRequest(TraktClient client) : base(client) { }

        public override string UriTemplate => "checkin";
    }
}
