using System;
using System.Collections.Generic;
using System.Text;

namespace GOL.Commom.Publisher
{
    public abstract class Query
    {
        public DateTime Timestamp { get; private set; }

        protected Query()
        {
            Timestamp = DateTime.Now;
        }

    }
}
