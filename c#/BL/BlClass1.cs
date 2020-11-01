using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    public class BlClass1 
    {
        public bool GetShadchnit(string name, string password)
        {
            using (var DB = new TestsDBnewEntities1())
            {
                var answer = DB.Users.Where(x => x.username == name && x.password.ToString() == password).Select(x => x.username).Any();
                if (answer)
                    return true;
                else
                    return false;
            }
        }

    }
}

            //foreach (shadchanit u in DB.Users)
            //{
            //    if (u.UserName == s.UserName)
            //    {
            //        if (u.Password == fu.Password)
            //            return Ok(true);
            //        else
            //            return Ok(u.Password);
            //    }
            //}
            //return Ok(false);