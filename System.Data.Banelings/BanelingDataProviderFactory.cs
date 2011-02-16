using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;

namespace System.Data.Banelings
{
    public class BanelingDataProviderFactory : DbProviderFactory
    {
        public override DbCommand CreateCommand()
        {
            return new BanelingDbCommand(); 
        }

        public override DbConnection CreateConnection()
        {
            return new BanelingDbConnection(); 
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new BanelingDbDataAdapter(); 
        }

        public override DbCommandBuilder CreateCommandBuilder()
        {
            return new BanelingDbCommandBuilder(); 
        }

        public override DbConnectionStringBuilder CreateConnectionStringBuilder()
        {
            return new BanelingDbConnectionStringBuilder(); 
        }

        public override DbDataSourceEnumerator CreateDataSourceEnumerator()
        {
            return new BanelingDbDataSourceEnumerator();
        }

        public override DbParameter CreateParameter()
        {
            return new BanelingDbParameter();
        }

        public override System.Security.CodeAccessPermission CreatePermission(System.Security.Permissions.PermissionState state)
        {
            return base.CreatePermission(state);
        }

        public override bool CanCreateDataSourceEnumerator
        {
            get
            {
                return base.CanCreateDataSourceEnumerator;
            }
        }

    }
}
