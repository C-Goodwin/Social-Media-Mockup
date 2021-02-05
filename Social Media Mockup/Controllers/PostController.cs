using Microsoft.AspNet.Identity;
using SocialMedia.Models;
using SocialMedia.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Social_Media_Mockup.Controllers
{
    public class PostController : ApiController
    {
        //POST (post)
        [HttpPost]
        public IHttpActionResult CreatePost(PostCreate post)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatedPostService();

            if (!service.CreatePost(post))
                return InternalServerError();

            return Ok();
        }

        // Helper Method
        private PostService CreatedPostService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var postService = new PostService(userId);
            return postService;
        }
    }
}
