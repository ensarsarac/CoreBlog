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
    public class Message2Manager : IMessage2Services
    {
        IMessage2Dal _message2Dal;

        public Message2Manager(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }

        public List<Message2> GetAllMessage2WithNamee(int p)
        {
            return _message2Dal.GetAllMessage2WithName(p);
        }

        public List<Message2> GetAllMessage2WithNamee2Manager(int p)
        {
            return _message2Dal.GetAllMessage2WithName2(p);
        }

        public Message2 GetById(int id)
        {
            return _message2Dal.GetById(id);
        }

        public List<Message2> GetInboxListByWriter(int p)
        {
            return _message2Dal.GetListAll(x => x.ReceiverId == p);
        }

        public List<Message2> GetList()
        {
            return _message2Dal.GetListAll();
        }

        public Message2 GetMessageIncludeUserWithIdManager(int id)
        {
            return _message2Dal.GetMessageIncludeUserWithId(id);
        }

        public List<Message2> SenderMessageWithIdManager(int id)
        {
            return _message2Dal.SenderMessageWithId(id);
        }

        public void TAdd(Message2 t)
        {
            _message2Dal.Insert(t);
        }

        public void TDelete(Message2 t)
        {
            _message2Dal.Delete(t);
        }

        public void TUpdate(Message2 t)
        {
            _message2Dal.Update(t);
        }
    }
}
