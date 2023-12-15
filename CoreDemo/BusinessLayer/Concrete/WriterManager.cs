using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {

        IWriterDal _writeDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writeDal = writerDal;
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
            return _writeDal.GetById(id);
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Writer t)
        {
            _writeDal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer t)
        {
            _writeDal.Update(t);
        }

        public void WriterAdd(Writer writer)
        {
            _writeDal.Insert(writer);

        }
    }
}
