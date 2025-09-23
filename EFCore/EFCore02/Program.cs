using EFCORE02.Context;

namespace EFCORE02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDBContext dbcontext = new ITIDBContext();
        }
    }
}
