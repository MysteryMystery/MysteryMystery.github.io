using Blazor.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;

namespace Blazor.Services
{
    public class CloutShootsService : ICloutShootsService
    {
        private HttpClient _httpClient;
        private IConfiguration _configuration;

        public CloutShootsService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<IEnumerable<CloutShoot>> GetCloutShoots(int year)
        {
            List<CloutShoot> shoots = new List<CloutShoot>();

            try
            {
                shoots = await _httpClient.GetFromJsonAsync<List<CloutShoot>>("/data/clout-shoots/" + year.ToString() + ".json");

                if (shoots is null)
                    return new List<CloutShoot>();

                return shoots.Select(s =>
                {
                    s.Guid = Guid.NewGuid();
                    return s;
                })
                .OrderBy(c => c.Date)
                .ToList();
            }
            catch (HttpRequestException e)
            {
                return new List<CloutShoot>();
            }
        }

        public async Task<IEnumerable<CloutShoot>> GetCurrentYearsCloutShoots()
        {
            DateTime now = DateTime.UtcNow;
            return await GetCloutShoots(now.Year);
        }

        public async Task<IEnumerable<CloutShoot>> GetNextCloutShoots(int currentYear)
        {
            var years = GetYears();
            int? nextYear = years.First(y => y > currentYear);

            if (nextYear.HasValue)
                return await GetCloutShoots(nextYear.Value);
            return new List<CloutShoot>();
        }

        public async Task<IEnumerable<CloutShoot>> GetPreviousCloutShoots(int currentYear)
        {
            var years = GetYears();
            int? prevYear = years.Last(y => y < currentYear);

            if (prevYear.HasValue)
                return await GetCloutShoots(prevYear.Value);
            return new List<CloutShoot>();
        }

        public IEnumerable<int> GetYears()
        {
            return _configuration.GetSection("cloutShoots:validYears").Get<IEnumerable<int>>();
        }
    }
}
