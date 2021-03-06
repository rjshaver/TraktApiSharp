﻿namespace TraktApiSharp.Experimental.Requests.Users.OAuth
{
    using System.Collections.Generic;
    using TraktApiSharp.Requests;

    internal sealed class TraktUserCustomSingleListRequest
    {
        internal TraktUserCustomSingleListRequest(TraktClient client) {}

        internal string Username { get; set; }

        public IDictionary<string, object> GetUriPathParameters()
        {
            var uriParams = new Dictionary<string, object>();
            uriParams.Add("username", Username);
            return uriParams;
        }

        public TraktAuthorizationRequirement AuthorizationRequirement => TraktAuthorizationRequirement.Optional;

        public TraktRequestObjectType RequestObjectType => TraktRequestObjectType.Lists;

        public string UriTemplate => "users/{username}/lists/{id}";
    }
}
