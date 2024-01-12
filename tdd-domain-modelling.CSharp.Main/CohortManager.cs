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

        public double Sum()
        {
            if (_cart.Count == 0) { return 0; } 
            else
            {
                double total = 0;
                foreach (var item in _cart)
                {
                    total += item.Item2 * item.Item3;
                }
                return total;
            }
            return -1;
        }

        public bool AddItem(string name, double price, int count)
        {
            try
            {
                _cart.Add((name, price, count));
                return true;
            }
            catch
            {
            return false;
            }
        }
    }
}
