using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public interface IAdminDal: IGenericDal<Admin>
    {

    }
}