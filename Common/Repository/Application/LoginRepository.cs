using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository.Application
{
    public class LoginRepository
    {
        MyContext myContext = new MyContext();
        public bool CheckLogin(string email, string password)
        {
            bool status = false;
            var get = myContext.User.Where(x => x.Email == email && x.Password == password && x.IsDelete == false && x.Role == 0).SingleOrDefault();
            try
            {
                if (get.Email == email && get.Password == password && get.IsDelete == false)
                {
                    status = true;
                    return status;
                }
                else
                {
                    return status;
                }
            }
            catch(Exception e)
            {
                e.GetBaseException();
                return status;
            }
        }
        public bool CheckAdmin(string email, string password)
        {
            bool status = false;
            var get = myContext.User.Where(x => x.Email == email && x.Password == password && x.IsDelete == false && x.Role == 1).SingleOrDefault();
            try
            {
                if (get.Email == email && get.Password == password && get.IsDelete == false)
                {
                    status = true;
                    return status;
                }
                else
                {
                    return status;
                }
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return status;
            }
        }
        public bool CheckHeadDivision(string email, string password)
        {
            bool status = false;
            var get = myContext.User.Where(x => x.Email == email && x.Password == password && x.IsDelete == false && x.Role == 2).SingleOrDefault();
            try
            {
                if (get.Email == email && get.Password == password && get.IsDelete == false)
                {
                    status = true;
                    return status;
                }
                else
                {
                    return status;
                }
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return status;
            }
        }
    }
}
