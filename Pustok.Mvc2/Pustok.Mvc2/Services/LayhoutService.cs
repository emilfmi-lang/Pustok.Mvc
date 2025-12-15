using Pustok.Mvc2.Data;
using Pustok.Mvc2.Models;

namespace Pustok.Mvc2.Services
{
    public class LayhoutService(AppDbContext db) 
    {
        public Dictionary<string, string> GetSettings()
        {
            return db.Settings.ToDictionary(s=> s.Key, s=> s.Value);
        }
    }
}
