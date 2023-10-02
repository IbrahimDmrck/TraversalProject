using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        public void ChangeToFalse(int id)
        {
            using (var context = new Context())
            {
                var guide = context.Guides.Find(id);
                guide.Status = false;
                context.Update(guide);
                context.SaveChanges();
            }
        }

        public void ChangeToTrue(int id)
        {
            using (var context = new Context())
            {
                var guide = context.Guides.Find(id);
                guide.Status = true;
                context.Update(guide);
                context.SaveChanges();
            }
        }
    }
}
