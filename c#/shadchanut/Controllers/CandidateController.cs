﻿using BL;
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
    public class CandidateController : ApiController
    {
        public IHttpActionResult GetShadchnit(Candidate c)
        {
            BlClass1 bl = new BlClass1();
            if (bl.(s.))
        }

    }
}
