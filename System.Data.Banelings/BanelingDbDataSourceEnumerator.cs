using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace System.Data.Banelings
{
    public class BanelingDbDataSourceEnumerator : DbDataSourceEnumerator
    {
        public override DataTable GetDataSources()
        {
            throw new BanelingException();
        }
    }
}
