using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace shadchanut.Controllers
{
    [EnableCors(methods: "*", headers: "*", origins: "*")]
    public class ShadchanitController : ApiController
    {
        [HttpPost]
        public IHttpActionResult GetShadchnit(shadchanit s)
        {
            BlClass1 bl = new BlClass1();
            if(bl.(s.))
        }
      
            if (bl.())
            {
                up = textBox2.Text;
                MessageBox.Show("שלום לך!!");
                Form2 f = new Form2();
                f.Show();
                staticclass.mark = 0;
            }
            else
            {
                MessageBox.Show("לא תקין");
            }
        
    }
}
    