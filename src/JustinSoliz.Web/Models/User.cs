using System;

namespace JustinSoliz.Web.Models
{
    public class User
    {
        public User()
        {
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
