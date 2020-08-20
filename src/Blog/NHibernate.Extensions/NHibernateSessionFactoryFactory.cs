using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;

namespace Mark.Donile.Blog
{
    public class NHibernateSessionFactoryFactory
    {
        public static ISessionFactory Create(string connectionString)
        {
            Configuration configuration = new Configuration();
            configuration.AddAssembly(typeof(NHibernateSessionFactoryFactory).Assembly.FullName);

            configuration.DataBaseIntegration(options => 
            {
                options.Dialect<PostgreSQLDialect>();
                options.ConnectionString = connectionString;
                options.LogFormattedSql = true;
                options.LogSqlInConsole = true;
            });

            return configuration.BuildSessionFactory();
        }
    }
}