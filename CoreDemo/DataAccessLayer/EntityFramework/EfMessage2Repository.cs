using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessage2Repository : GenericRepository<Message2>, IMessage2Dal
    {

        Context c = new Context();
        public List<Message2> GetAllMessage2WithName(int id)
        {
            return c.Message2s.Include(x => x.SenderUser).Where(x=>x.ReceiverId == id).Where(z=>z.MessageStatus==true).ToList(); 

        }

        public List<Message2> GetAllMessage2WithName2(int id)
        {
            return c.Message2s.Include(x => x.SenderUser).Where(x => x.ReceiverId == id).OrderByDescending(y=>y.MessageDate).ToList();

        }

        public List<Message2> SenderMessageWithId(int id)
        {
            return c.Message2s.Include(x => x.ReceiverUser).Where(x => x.SenderId == id).OrderByDescending(y => y.MessageDate).ToList();

        }

        public Message2 GetMessageIncludeUserWithId(int id)
        {
            return c.Message2s.Include(x => x.SenderUser).Include(z=>z.ReceiverUser).Where(y => y.MessageId == id).FirstOrDefault();
        }
    }
}
