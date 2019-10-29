using System.Threading.Tasks;

namespace lami.Data
{
    public interface IlamiDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
