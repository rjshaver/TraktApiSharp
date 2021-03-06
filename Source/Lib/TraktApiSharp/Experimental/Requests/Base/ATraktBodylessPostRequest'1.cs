﻿namespace TraktApiSharp.Experimental.Requests.Base
{
    using Interfaces.Base;
    using System.Net.Http;
    using TraktApiSharp.Requests;

    internal abstract class ATraktBodylessPostRequest<TContentType> : ATraktRequest<TContentType>, ITraktBodylessPostRequest<TContentType>
    {
        public override TraktAuthorizationRequirement AuthorizationRequirement => TraktAuthorizationRequirement.Required;

        public sealed override HttpMethod Method => HttpMethod.Post;
    }
}
