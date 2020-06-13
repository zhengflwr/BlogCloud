using IRepository;
using System;

namespace Repository
{
    public class TestRepository : ITestRepository
    {
        public int Sum(int i, int j)
        {
            return i + j;
        }
    }
}
