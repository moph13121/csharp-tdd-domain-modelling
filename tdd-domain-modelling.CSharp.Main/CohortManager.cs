using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        private List<(string, double, int)> _cart = new List<(string, double, int)> ();
        
        public CohortManager() { }

        public int Sum()
        {

            return -1;
        }

        public bool AddItem(string name, double price, int count)
        {

            return false;
        }
    }
}
