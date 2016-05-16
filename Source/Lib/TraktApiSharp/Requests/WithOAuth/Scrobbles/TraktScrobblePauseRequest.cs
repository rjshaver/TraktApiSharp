﻿namespace TraktApiSharp.Requests.WithOAuth.Scrobbles
{
    using Base.Post;
    using Objects.Post;

    internal class TraktScrobblePauseRequest<TResponse, TRequest> : TraktPostRequest<TResponse, TResponse, TRequest> where TRequest : IValidatable
    {
        internal TraktScrobblePauseRequest(TraktClient client) : base(client) { }

        protected override string UriTemplate => "scrobble/pause";

        protected override void Validate()
        {
            base.Validate();
            RequestBody.Validate();
        }
    }
}