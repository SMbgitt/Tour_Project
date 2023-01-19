namespace TourGuideExample.BLL;

public class CountryBase
{
    public int Id { get; set; }
    public int ContinentId { get; set; }
    public int CurrencyId { get; set; }
    public int DangerId { get; set; }
    public int PictureId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string TimeZone { get; set; }
    public string Weather { get; set; }
    public string Kitchen { get; set; }
}
