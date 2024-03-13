using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace GYM.Model
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public Context()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=C:\\Users\\Usuário\\source\\repos\\GYM_APP\\GYM_APP\\DB\\Users");

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
