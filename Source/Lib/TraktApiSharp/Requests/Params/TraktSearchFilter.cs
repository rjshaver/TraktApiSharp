﻿namespace TraktApiSharp.Requests.Params
{
    using System;
    using Utils;

    /// <summary>
    /// Provides additional filter parameters for the new search methods.<para />
    /// Supported by <see cref="Modules.TraktSearchModule.GetTextQueryResultsAsync(Enums.TraktSearchResultType, string, Enums.TraktSearchField, TraktSearchFilter, TraktExtendedInfo, int?, int?)" />.<para />
    /// This class has an fluent interface.
    /// <para>See <a href ="http://docs.trakt.apiary.io/#introduction/filters">"Trakt API Doc - Filters"</a> for more information.</para>
    /// </summary>
    public class TraktSearchFilter : TraktCommonFilter
    {
        /// <summary>Initializes an <see cref="TraktSearchFilter" /> instance with the given values.</summary>
        /// <param name="startYear">An optional four digit start year for the years parameter.</param>
        /// <param name="endYear">An optional four digit end year for the years parameter.</param>
        /// <param name="genres">An optional array of Trakt genre slugs.</param>
        /// <param name="languages">An optional array of two letter language codes.</param>
        /// <param name="countries">An optional array of two letter country codes.</param>
        /// <param name="runtimes">An optional <see cref="Range{T}" /> instance for minutes.</param>
        /// <param name="ratings">An optional <see cref="Range{T}" /> instance for ratings.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown, if the given <paramref name="startYear" /> value does not have four digits.
        /// Thrown, if the given <paramref name="endYear" /> value does not have four digits.
        /// Thrown, if the begin value of the given runtimes range is below zero or if its end value is below zero or
        /// if its end value is below its begin value.
        /// Thrown, if the begin value of the given ratings range is below zero or if its end value is below zero or
        /// if its end value is below its begin value or if its end value is above 100.
        /// Thrown, if the given language codes array contains a language code, which has more or less than two letters.
        /// Thrown, if the given country codes array contains a country code, which has more or less than two letters.
        /// </exception>
        public TraktSearchFilter(int? startYear = null, int? endYear = null, string[] genres = null, string[] languages = null,
                                 string[] countries = null, Range<int>? runtimes = null, Range<int>? ratings = null)
            : base(startYear, endYear, genres, languages, countries, runtimes, ratings) { }

        /// <summary>Sets the start year for the years parameter value.</summary>
        /// <param name="startYear">A four digit year.</param>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown, if the given year does not have four digits.</exception>
        public new TraktSearchFilter WithStartYear(int startYear)
        {
            base.WithStartYear(startYear);
            return this;
        }

        /// <summary>Sets the end year for the years parameter value.</summary>
        /// <param name="endYear">A four digit year.</param>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown, if the given year does not have four digits.</exception>
        public new TraktSearchFilter WithEndYear(int endYear)
        {
            base.WithEndYear(endYear);
            return this;
        }

        /// <summary>Sets the start and end year for the years parameter value.</summary>
        /// <param name="startYear">A four digit year.</param>
        /// <param name="endYear">A four digit year.</param>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown, if at least on of the given year values does not have four digits.</exception>
        public new TraktSearchFilter WithYears(int startYear, int endYear)
        {
            base.WithYears(startYear, endYear);
            return this;
        }

        /// <summary>Deletes the current start year of the years parameter.</summary>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        public new TraktSearchFilter ClearStartYear()
        {
            base.ClearStartYear();
            return this;
        }

        /// <summary>Deletes the current end year of the years parameter.</summary>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        public new TraktSearchFilter ClearEndYear()
        {
            base.ClearEndYear();
            return this;
        }

        /// <summary>Deletes the current years parameter.</summary>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        public new TraktSearchFilter ClearYears()
        {
            base.ClearYears();
            return this;
        }

        /// <summary>Adds multiple Trakt genre slugs to the already existing Trakt genre slugs.</summary>
        /// <param name="genre">A Trakt genre slug.</param>
        /// <param name="genres">An optional array of Trakt genre slugs.</param>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        public new TraktSearchFilter AddGenres(string genre, params string[] genres)
        {
            base.AddGenres(genre, genres);
            return this;
        }

        /// <summary>Sets the Trakt genre slugs parameter and overwrites already existing ones with given Trakt genre slugs.</summary>
        /// <param name="genre">A Trakt genre slug.</param>
        /// <param name="genres">An optional array of Trakt genre slugs.</param>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        public new TraktSearchFilter WithGenres(string genre, params string[] genres)
        {
            base.WithGenres(genre, genres);
            return this;
        }

        /// <summary>Deletes the current genre values.</summary>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        public new TraktSearchFilter ClearGenres()
        {
            base.ClearGenres();
            return this;
        }

        /// <summary>Adds multiple language codes to the already existing language codes.</summary>
        /// <param name="language">A two letter language code.</param>
        /// <param name="languages">An optional array of two letter language codes.</param>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown, if one the given language codes has more or less than two letters.
        /// </exception>
        public new TraktSearchFilter AddLanguages(string language, params string[] languages)
        {
            base.AddLanguages(language, languages);
            return this;
        }

        /// <summary>Sets the language codes parameter and overwrites already existing ones with given language codes.</summary>
        /// <param name="language">A two letter language code.</param>
        /// <param name="languages">An optional array of two letter language codes.</param>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown, if one the given language codes has more or less than two letters.
        /// </exception>
        public new TraktSearchFilter WithLanguages(string language, params string[] languages)
        {
            base.WithLanguages(language, languages);
            return this;
        }

        /// <summary>Deletes the current language values.</summary>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        public new TraktSearchFilter ClearLanguages()
        {
            base.ClearLanguages();
            return this;
        }

        /// <summary>Adds multiple country codes to the already existing country codes.</summary>
        /// <param name="country">A two letter country code.</param>
        /// <param name="countries">An optional array of two letter country codes.</param>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown, if one the given country codes has more or less than two letters.
        /// </exception>
        public new TraktSearchFilter AddCountries(string country, params string[] countries)
        {
            base.AddCountries(country, countries);
            return this;
        }

        /// <summary>Sets the country codes parameter and overwrites already existing ones with given country codes.</summary>
        /// <param name="country">A two letter country code.</param>
        /// <param name="countries">An optional array of two letter country codes.</param>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown, if one the given country codes has more or less than two letters.
        /// </exception>
        public new TraktSearchFilter WithCountries(string country, params string[] countries)
        {
            base.WithCountries(country, countries);
            return this;
        }

        /// <summary>Deletes the current country values.</summary>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        public new TraktSearchFilter ClearCountries()
        {
            base.ClearCountries();
            return this;
        }

        /// <summary>Sets the runtimes value parameter and overwrites already exisiting values with the given ones.</summary>
        /// <param name="begin">The begin value of the runtimes range.</param>
        /// <param name="end">The end value of the runtimes range.</param>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown, if the given begin value is below zero or if the given end value is below zero or
        /// if the given end value is below the given begin value.
        /// </exception>
        public new TraktSearchFilter WithRuntimes(int begin, int end)
        {
            base.WithRuntimes(begin, end);
            return this;
        }

        /// <summary>Deletes the current runtime values.</summary>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        public new TraktSearchFilter ClearRuntimes()
        {
            base.ClearRuntimes();
            return this;
        }

        /// <summary>Sets the ratings value parameter and overwrites already exisiting values with the given ones.</summary>
        /// <param name="begin">The begin value of ratings range.</param>
        /// <param name="end">The end value of the ratings range.</param>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown, if the given begin value is below zero or if the given end value is below zero or
        /// if the given end value is below the given begin value or if the given end value is above 100.
        /// </exception>
        public new TraktSearchFilter WithRatings(int begin, int end)
        {
            base.WithRatings(begin, end);
            return this;
        }

        /// <summary>Deletes the current rating values.</summary>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        public new TraktSearchFilter ClearRatings()
        {
            base.ClearRatings();
            return this;
        }

        /// <summary>Deletes all filter parameter values.</summary>
        /// <returns>The current <see cref="TraktSearchFilter" /> instance.</returns>
        public new TraktSearchFilter Clear()
        {
            base.Clear();
            return this;
        }
    }
}
