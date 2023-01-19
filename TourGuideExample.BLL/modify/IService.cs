using TourASP.models;

namespace TourASP.Service
{
    public interface IService<T>
    {
        List<T> GetValues();
        T GetValue(int Id);
    }
}
