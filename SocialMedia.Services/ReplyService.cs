using SocialMedia.Data;
using SocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public class ReplyService
    {
        public ReplyDetail GetNoteById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Replies
                        .Single(e => e.ReplyId == id && e.Author == _userId);
                return
                    new ReplyDetail
                    {
                        ReplyId = entity.ReplyId,
                        Text = entity.Text,
                        Author = entity.Author
                    };
            }
        }
    }
}
