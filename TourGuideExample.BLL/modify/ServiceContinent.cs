using TourASP.models;
namespace TourASP.Service
{
    public class DataService<T>:IService<T>
    {
        private readonly Repository<T> _repo;
        public List<T> GetValues()
        {
            List<T> data = new List<T>();
            try
            {
                data = _repo.Get();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Could not find entities", ex);
            }
            return data;
        }
        public T GetValue(int id)
        {
            try
            {
                T data = _repo.GetItemById(id);
                return data;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Could not find entity by id {id}", ex);
            }
        }
    }
}
