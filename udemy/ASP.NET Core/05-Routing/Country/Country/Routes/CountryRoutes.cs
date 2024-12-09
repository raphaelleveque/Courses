using System;
using Country.Models;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore;

namespace Country.Routes
{
	public static class CountryRoutes
	{
		public static void MapCountryRoutes(this WebApplication app)
		{
			var countriesData = app.Services.GetRequiredService<IOptions<CountriesData>>().Value;

            if (countriesData is null)
            {
                throw new InvalidOperationException("Countries data is not configured.");
            }

            app.MapGet("/countries", () =>
            {
                return Results.Ok(countriesData.Countries);
            });

            app.MapGet("/countries/{countryId:int}", (int countryID) =>
            {
                if (countriesData.Countries.ContainsKey(countryID)) return Results.Ok(countriesData.Countries[countryID]);
                return Results.NotFound();
            });

            app.MapGet("/countries/name/{name}", (string name) =>
            {
                var country = countriesData.Countries.Values.FirstOrDefault(c => string.Equals(c?.Name, name, StringComparison.OrdinalIgnoreCase));
                if (country is null) return Results.NotFound();
                return Results.Ok(country);
            });

            app.MapGet("/countries/count", () =>
            {
                return Results.Ok(new { Count = countriesData.Countries.Count });
            });

            app.MapGet("/countries/languages/{language}", (string language) =>
            {
                var countries = countriesData.Countries.Values
                    .Where(c => c.Languages.Any(lang =>
                        string.Equals(lang, language, StringComparison.OrdinalIgnoreCase)));

                if (!countries.Any()) return Results.NotFound();
                return Results.Ok(countries);
            });
        }

    }
}

