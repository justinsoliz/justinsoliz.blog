
namespace JustinSoliz.Web.Models
{
    public class Blog
    {
        private static string _blogUrl;
        public static string BlogUrl
        {
            get
            {
                return _blogUrl ??
                       (_blogUrl = GlobalEnv.InProduction ?
                       "http://www.justinsoliz.com" : "http://justinsoliz");
            }
        }

        public const string BlogName = "Your Awesome Blog";
        public const string Author = "Justin";
        public const string BlogTagLine = "Let's build a rocket!";
    }
}
