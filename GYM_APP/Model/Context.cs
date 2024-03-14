using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace GYM.Model
{
    public class Context : DbContext
    {

        public string DbPath { get; }

        public Context()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "users.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<User> Users { get; set; }

    }

    public class MyControler
    {
        private readonly Context _context;

        public MyControler(Context context)
        {
            _context = context;
        }
    }
}
