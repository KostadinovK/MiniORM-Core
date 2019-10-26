using System.Collections.Generic;

namespace MiniORM
{
	// TODO: Create your DbSet class here.
    public class DbSet<T>
        where T : class, new()
    {
        public IEnumerable<T> Entities { get; set; }
    }
}