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
    public class AboutManager : IAbout2Service
    {
        IAbout2Dal _about;

        public AboutManager(IAbout2Dal about)
        {
            _about = about;
        }

        public void TAdd(About2 t)
        {
            _about.Insert(t);   
        }

        public void TDelete(About2 t)
        {
            _about.Delete(t);
        }

        public About2 TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About2> TGetList()
        {
            return _about.GetList();    
        }

        public void TUpdate(About2 t)
        {
            _about.Update(t);
        }
    }
}
