﻿using SocialMedia.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Social_Media_Mockup.Controllers
{
    public class CommentController : ApiController
    {
        public IHttpActionResult Get(int id)
        {
            CommentService cService = CreateCommentService();
            var comment = cService.GetCommentById(id);
            return Ok(comment);
        }

    }
}
