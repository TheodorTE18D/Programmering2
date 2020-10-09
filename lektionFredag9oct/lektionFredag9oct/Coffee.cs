using System;
using System.Collections.Generic;
using System.Text;

namespace lektionFredag9oct
{
    class Coffee : produkt
    {
        private string _roastyness;

        public string Roastyness
        {
            get { return _roastyness; }
            set { _roastyness = value; }
        }

    }
}
