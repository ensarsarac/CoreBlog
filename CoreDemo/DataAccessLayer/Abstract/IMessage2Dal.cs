using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMessage2Dal: IGenericDal<Message2>
    {
        public List<Message2> GetAllMessage2WithName(int id);
        public List<Message2> GetAllMessage2WithName2(int id);
        public Message2 GetMessageIncludeUserWithId(int id);

        public List<Message2> SenderMessageWithId(int id);
    }
}
