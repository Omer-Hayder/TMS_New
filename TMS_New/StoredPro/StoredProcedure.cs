using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TMS_New.Models;

namespace TMS_New.StoredPro
{
    public class StoredProcedure
    {
        public bool aspnet_Users_CreateUser(aspnet_Users model)
        {
            try
            {
                model.UserId = Guid.NewGuid();
                model.UserName = model.UserName.ToLower();

                using (DBModel db = new DBModel())
                {
                    db.aspnet_Users.Add(model);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //public bool aspnet_Membership_CreateUser(aspnet_Membership model)
        //{

        //}
    }
}