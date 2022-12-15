﻿using RateMyManagement.Data;
using RMM.Data;

namespace RateMyManagement.IServices
{
    public interface IMongoService
    {
        #region Company
        public Task CreateCompanyAsync(Company company);
        public Task<(bool, Company?)> TryGetCompanyAsync(string companyId);
        public Task AddLocationIdToCompanyAsync(string companyId, string locationId);
        public Task<List<Company>> GetAllCompaniesAsync();
        public Task UpdateCompanyDetailsAsync(string id, string name, string industry, string description);
        public Task<List<Company>> QueryCompaniesByStartingLetter(char letter);
        #endregion

        #region Location
        public Task CreateLocationAsync(Location company);
        public Task<(bool, Location?)> TryGetLocationAsync(string locationId);
        public Task AddLocationReviewAsync(string locationId, LocationReview review);
        public Task UpdateLocationDetailsAsync(string id, string address, string city);
        #endregion
    }
}
