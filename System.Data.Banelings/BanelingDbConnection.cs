using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace System.Data.Banelings
{
    public class BanelingDbConnection : DbConnection
    {
        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            throw new BanelingException();
        }

        public override void ChangeDatabase(string databaseName)
        {
            throw new BanelingException();
        }

        public override void Close()
        {
            throw new BanelingException();
        }

        public override string ConnectionString
        {
            get
            {
                throw new BanelingException();
            }
            set
            {
                throw new BanelingException();
            }
        }

        protected override DbCommand CreateDbCommand()
        {
            throw new BanelingException();
        }

        public override string DataSource
        {
            get { throw new BanelingException(); }
        }

        public override string Database
        {
            get { throw new BanelingException(); }
        }

        public override void Open()
        {
            throw new BanelingException();
        }

        public override string ServerVersion
        {
            get { throw new BanelingException(); }
        }

        public override ConnectionState State
        {
            get { throw new BanelingException(); }
        }
    }
}
