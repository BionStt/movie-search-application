using System;
using System.Collections.Generic;
using MovieSearch.Core.Companies;
using MovieSearch.Core.Generals;
using MovieSearch.Core.Genres;
using MovieSearch.Core.Keywords;
using MovieSearch.Core.Movies;

namespace MovieSearch.IntegrationTests.Mocks
{
    public static class MovieMocks
    {
        public static Movie Data => new()
        {
            Id = 140607,
            ImdbId = "tt2488496",
            Title = "Star Wars: The Force Awakens",
            OriginalTitle = "Star Wars: The Force Awakens",
            Tagline = "Every generation has a story.",
            Overview = "Thirty years after defeating the Galactic Empire",
            OriginalLanguage = "en",
            Homepage = "http://www.starwars.com/films/star-wars-episode-vii",
            Status = "Released",
            Budget = 245000000,
            Runtime = 136,
            ReleaseDate = new DateTime(2015, 12, 15),
            SpokenLanguages = new List<Language> { new("en", "English") },
            ProductionCompanies = new List<ProductionCompany>
            {
                new()
                {
                    Id = 1, Name = "Lucasfilm Ltd.", LogoPath = "/o86DbpburjxrqAzEDhXZcyE8pDb.png", OriginCountry = "US"
                },
                new()
                {
                    Id = 11461, Name = "Bad Robot", LogoPath = "/p9FoEt5shEKRWRKVIlvFaEmRnun.png", OriginCountry = "US"
                },
            },
            ProductionCountries = new List<Country>
            {
                new("US", "United States of America"),
            },
            Genres = new List<Genre>
            {
                GenreFactory.Action(),
                GenreFactory.Adventure(),
                GenreFactory.ScienceFiction(),
                GenreFactory.Fantasy(),
            },
        };
    }
}