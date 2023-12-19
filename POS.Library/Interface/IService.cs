using POSLibrary.DataModels;
using POSLibrary.DataModels.Product;
using POSLibrary.DataModels.Results;

namespace POSLibrary.Interface
{
    public interface IService<TR,TC,TU> where TR : class
                                        where TC : class
                                        where TU : class
    {
        //IEnumerable<TR> ReadAll();
        Results<IEnumerable<TR?>> ReadAll();
        Results<TR> GetById(ulong id);
        Results<string> Create(TC req);
        Results<string> Update(TU req);
        Results<string> Delete(ulong id);
    }
}
