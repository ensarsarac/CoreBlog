using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessage2Services: IGenericService<Message2>
    {
        List<Message2> GetInboxListByWriter(int p);
        List<Message2> GetAllMessage2WithNamee(int p);
        List<Message2> GetAllMessage2WithNamee2Manager(int p);

        Message2 GetMessageIncludeUserWithIdManager(int id);

        List<Message2> SenderMessageWithIdManager(int id);
    }
}
