using System;
using System.Reflection;

namespace MiniORM
{
	// TODO: Create your DbContext class here.
    public abstract class DbContext
    {
        public static Type[] AllowedSqlTypes =
        {
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong),
            typeof(string),
            typeof(DateTime),
            typeof(double),
            typeof(decimal),
            typeof(bool)
        };
    }
}