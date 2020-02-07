using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrac
{
    public class Name
    {
        public string name;
        public List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

        public void GetList()
        {
            var distinctlist = names.Distinct();
            foreach (var name in distinctlist)
            {
                Console.WriteLine(" ");
            }
        }
    }

}
