using System;
using System.Configuration;

namespace JustinSoliz.Web
{
    public class GlobalEnv
    {
        private static EnvironmentType _environment;

        static GlobalEnv()
        {
            Enum.TryParse(ConfigurationManager
                .AppSettings["Env"], true, out _environment);
        }

        public static string ConnectionString
        {
            get
            {
                return InProduction ? "JustinSoliz.Web.ConnectionString.Production"
                    : "JustinSoliz.Web.ConnectionString";
            }
        }

        public static EnvironmentType Environment
        {
            get { return _environment; }
            set { _environment = value; }
        }

        public static bool InDev
        {
            get { return Environment == EnvironmentType.Development; }
        }

        public static bool InProduction
        {
            get { return Environment == EnvironmentType.AppHarbor; }
        }
    }

    public enum EnvironmentType
    {
        Development,
        Testing,
        Staging,
        Production,
        AppHarbor
    }
}
