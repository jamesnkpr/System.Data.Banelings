using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace System.Data.Banelings
{
    public class BanelingDbCommand : DbCommand
    {

        public override void Cancel()
        {
            throw new BanelingException();
        }

        public override string CommandText
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

        public override int CommandTimeout
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

        public override CommandType CommandType
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

        protected override DbParameter CreateDbParameter()
        {
            throw new BanelingException();
        }

        protected override DbConnection DbConnection
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

        protected override DbParameterCollection DbParameterCollection
        {
            get { throw new BanelingException(); }
        }

        protected override DbTransaction DbTransaction
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

        public override bool DesignTimeVisible
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

        protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
        {
            throw new BanelingException();
        }

        public override int ExecuteNonQuery()
        {
            throw new BanelingException();
        }

        public override object ExecuteScalar()
        {
            throw new BanelingException();
        }

        public override void Prepare()
        {
            throw new BanelingException();
        }

        public override UpdateRowSource UpdatedRowSource
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
    }
}
