using System.Collections.Generic;
using System.Web.Routing;

namespace JustinSoliz.Web.Models
{
    public class Category
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Category ParentCategory { get; set; }
        public virtual string Slug { get; set; }
        public virtual IList<Category> SubCategories { get; set; }
        public virtual IList<Post> Posts { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}