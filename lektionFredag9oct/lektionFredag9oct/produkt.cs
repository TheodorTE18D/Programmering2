using System;
using System.Collections.Generic;
using System.Text;

namespace lektionFredag9oct
{
    class produkt
    {
        private int _productNumber;


        public int ProductNumber
        {
            get { return _productNumber; }
            set { _productNumber = value; }
        }

        private int _StockStatus;

        public int StockStatus
        {
            get { return _StockStatus;  }
            set { _StockStatus = value; }
        }
    }
}
