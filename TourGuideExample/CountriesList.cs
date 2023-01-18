using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TourGuideExample;

public class ProbaList : INotifyPropertyChanged
{
    string _urlPhoto = "";
    string _countryName = "";

    public string UrlPhoto
    {
        get { return _urlPhoto; }
        set
        {
            _urlPhoto = value;
            OnPropertyChanged(nameof(UrlPhoto));
        }
    }
    public string CountryName
    {
        get { return _countryName; }
        set
        {
            _countryName = value;
            OnPropertyChanged(nameof(CountryName));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    }
}
