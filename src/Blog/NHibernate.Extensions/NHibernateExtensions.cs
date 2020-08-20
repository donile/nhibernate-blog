using Microsoft.Extensions.DependencyInjection;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;

namespace Mark.Donile.NHibernateExtensions
{
    public static class NHibernateExtensions
    {
        public static IServiceCollection AddNHibernate(this IServiceCollection services, string connectionString)
        {            
            Configuration configuration = new Configuration();
            configuration.AddAssembly(typeof(NHibernateExtensions).Assembly.FullName);

            configuration.DataBaseIntegration(options => 
            {
                options.Dialect<PostgreSQLDialect>();
                options.ConnectionString = connectionString;
                options.LogFormattedSql = true;
                options.LogSqlInConsole = true;
            });

            ISessionFactory sessionFactory = configuration.BuildSessionFactory();

            services.AddSingleton<ISessionFactory>(sessionFactory);
            services.AddTransient<ISession>(sp => sp.GetService<ISessionFactory>().OpenSession());
            return services;
        }
    }
}