using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Models
{
    public class TestRepository : ITestRepository
    {
        public IEnumerable<TestModel> GetItems()
        {
            return new List<TestModel>
            {
                new TestModel { TestMessage = "marchew" },
                new TestModel { TestMessage = "Wiadomosc z modelu 2" },
                new TestModel { TestMessage = "Wiadomosc z modelu 3" },
                new TestModel { TestMessage = "Wiadomosc z modelu 4" },
            };
        }
    }
}