using Dapper;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace TourGuideExample.BLL;

public class RequestInfo
{
    string connectionString = @"Server=DESKTOP-Q6RQB80;Database=TourDB;Trusted_Connection=True;";
    public List<CountryBase> GetCountries()
    {
        List<CountryBase> countries = new List<CountryBase>();

        try
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();

                countries = db.Query<CountryBase>("SELECT * FROM Country").ToList();
            }
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }

        return countries;
    }
    public CountryBase GetCountryById(int countryId)
    {
        CountryBase country = new CountryBase();
        try
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();

                country = db.QueryFirstOrDefault<CountryBase>("SELECT * FROM Country where Id = @Id",
                                new { Id = countryId });
            }
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }

        return country;
    }

    public List<CountryBase> GetCountriesListById(int continentId)
    {
        List<CountryBase> country = new List<CountryBase>();
        try
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();

                country = db.Query<CountryBase>("SELECT * FROM Country where ContinentId = @ContinentId",
                                new { ContinentId = continentId }).ToList();
            }
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }

        return country;
    }

    public List<SightBase> GetSightsByCountryId(int countryId)
    {
        List<SightBase> sights = new List<SightBase>();

        try
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();

                sights = db.Query<SightBase>("SELECT * FROM Sight where CountryId = @CountryId",
                                new { CountryId = countryId }).ToList();
            }
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }

        return sights;
    }

    public List<FactBase> GetFactsByCountryId(int countryId)
    {
        List<FactBase> facts = new List<FactBase>();

        try
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();

                facts = db.Query<FactBase>("SELECT * FROM Fact where CountryId = @CountryId",
                                new { CountryId = countryId }).ToList();
            }
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }

        return facts;
    }




    public List<CountryCurrencyBase> GetCountryCurrencyId(int countryId)
    {
        List<CountryCurrencyBase> CurrencyId = new List<CountryCurrencyBase>();

        try
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();

                CurrencyId = db.Query<CountryCurrencyBase>("SELECT * FROM CountryCurrency where CountryId = @CountryId",
                                new { CountryId = countryId }).ToList();
            }
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }

        return CurrencyId;
    }

    public List<CountryDangerous> GetCountryDangerousId(int countryId)
    {
        List<CountryDangerous> DangerousId = new List<CountryDangerous>();

        try
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();

                DangerousId = db.Query<CountryDangerous>("SELECT * FROM CountryDangerous where CountryId = @CountryId",
                                new { CountryId = countryId }).ToList();
            }
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }

        return DangerousId;
    }



    public List<CurrencyBase> GetCurrencyByCountryId(List<CountryCurrencyBase> currencysIdList)
    {
        List<CurrencyBase> CurrencyId = new List<CurrencyBase>();

        foreach(CountryCurrencyBase currencyBase in currencysIdList)
        { 
            try
            {
                using (SqlConnection db = new SqlConnection(connectionString))
                {
                    db.Open();

                    CurrencyId = db.Query<CurrencyBase>("SELECT * FROM Currency where Id = @Id",
                                    new { Id = currencyBase.CurrencyId }).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
        return CurrencyId;
    }
   


    public List<DangerBase> GetDangerousByCountryId(List<CountryDangerous> dangerousIdList)
    {
        List<DangerBase> DangerId = new List<DangerBase>();

        foreach(CountryDangerous dangerousBase in dangerousIdList)
        { 
            try
            {
                using (SqlConnection db = new SqlConnection(connectionString))
                {
                    db.Open();

                    DangerId = db.Query<DangerBase>("SELECT * FROM Danger where Id = @Id",
                                    new { Id = dangerousBase.DangerId }).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
        return DangerId;
    }

   

}
