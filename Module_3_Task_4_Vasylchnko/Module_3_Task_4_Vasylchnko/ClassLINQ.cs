using System;
using System.Collections.Generic;
using System.Linq;

namespace Module_3_Task_4_Vasylchnko
{
    public class ClassLINQ
    {
        private List<string> _contacts = new List<string>()
        {
            "Dima",
            "Alex",
            "Andro",
            "Kiril",
            "Anton",
            "Stepan",
            "Petro",
            "Liza",
            "Dasha",
            "Nina",
            "Kate"
        };

        public void TestLINQ()
        {
            var select = _contacts.Select(i => new { i, i.Length });
            var where = _contacts.Where(i => i.ToUpper().StartsWith("S"));
            var orderBy = _contacts.OrderBy(i => i.Length);
            var orderByDescenting = _contacts.OrderByDescending(i => i);
            var thenBy = _contacts.OrderBy(i => i.Length).ThenBy(i => i);
            var thenByDescending = _contacts.OrderBy(i => i.Length).ThenByDescending(i => i);
            _contacts.Reverse();
            var all = _contacts.All(s => s.Length > 1);
            var any = _contacts.Any(s => s.StartsWith("L"));
            var count = _contacts.Count(s => s.StartsWith("L"));
            var take = _contacts.Take(2);
            var skip = _contacts.Skip(3);
            var constains = _contacts.Contains("Dima");
            var distinct = _contacts.Distinct();
            var except = _contacts.Except(where);
            var union = _contacts.Union(where);
            var intersect = _contacts.Intersect(where);
            var contact = _contacts.Concat(where);
            var first = _contacts.First(i => i.ToUpper().StartsWith("A"));
            var firstOrDefault = _contacts.FirstOrDefault(i => i.StartsWith("b"));
            var single = where.Single();
            var singleOrDefault = where.SingleOrDefault();
            var elementAt = _contacts.ElementAt(7);
            var elementAtOrDefault = _contacts.ElementAtOrDefault(100);
            var last = _contacts.Last(i => i.StartsWith("A"));
            var lastOrDefault = _contacts.LastOrDefault(i => i.ToUpper().StartsWith("Z"));
        }
    }
}
