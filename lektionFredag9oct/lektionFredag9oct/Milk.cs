﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lektionFredag9oct
{
    class Milk : produkt
    {
        private int _fatContent;

        public int FatContent
        {
            get { return _fatContent; }
            set { _fatContent = value; }
        }
    }
}
