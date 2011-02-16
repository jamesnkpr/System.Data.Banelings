using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace System.Data.Banelings
{
    public class BanelingDbDataAdapter : DbDataAdapter
    {
        #region IDbDataAdapter Members

        public IDbCommand DeleteCommand
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

        public IDbCommand InsertCommand
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

        public IDbCommand SelectCommand
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

        public IDbCommand UpdateCommand
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

        #endregion

        #region IDataAdapter Members

        public int Fill(DataSet dataSet)
        {
            throw new BanelingException();
        }

        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new BanelingException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new BanelingException();
        }

        public MissingMappingAction MissingMappingAction
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

        public MissingSchemaAction MissingSchemaAction
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

        public ITableMappingCollection TableMappings
        {
            get { throw new BanelingException(); }
        }

        public int Update(DataSet dataSet)
        {
            throw new BanelingException();
        }

        #endregion
    }
}
