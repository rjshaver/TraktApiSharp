﻿namespace TraktApiSharp.Experimental.Requests.Calendars.OAuth
{
    using Objects.Get.Calendars;

    internal sealed class TraktCalendarUserNewShowsRequest : ATraktCalendarUserRequest<TraktCalendarShow>
    {
        public override string UriTemplate => "calendars/my/shows/new{/start_date}{/days}{?extended,query,years,genres,languages,countries,runtimes,ratings}";
    }
}
