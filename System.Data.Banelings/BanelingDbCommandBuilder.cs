using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace System.Data.Banelings
{
    public class BanelingDbCommandBuilder : DbCommandBuilder
    {
        protected override void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause)
        {
            throw new BanelingException();
        }

        protected override string GetParameterName(string parameterName)
        {
            throw new BanelingException();
        }

        protected override string GetParameterName(int parameterOrdinal)
        {
            throw new BanelingException();
        }

        protected override string GetParameterPlaceholder(int parameterOrdinal)
        {
            throw new BanelingException();
        }

        protected override void SetRowUpdatingHandler(DbDataAdapter adapter)
        {
            throw new BanelingException();
        }
    }
}
