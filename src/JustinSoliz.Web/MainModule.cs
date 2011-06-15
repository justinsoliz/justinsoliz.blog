using Nancy;

namespace JustinSoliz.Web
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = x => {
                return View["~/Views/index.cshtml"];
            };
        }
    }
}