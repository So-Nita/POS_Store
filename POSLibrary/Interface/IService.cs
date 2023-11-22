
namespace POSLibrary.Interface
{
    public interface IService<TR,TC,TU> where TR : class
                                        where TC : class
                                        where TU : class
    {
        List<TR> ReadAll();
        string Create(TC c);
        bool Update(TR t);
        bool Delete(string t);
    }
}
