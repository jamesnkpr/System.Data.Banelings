using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace System.Data.Banelings
{
    public class BanelingDbParameter : DbParameter
    {
        public override DbType DbType
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

        public override ParameterDirection Direction
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

        public override bool IsNullable
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

        public override string ParameterName
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

        public override void ResetDbType()
        {
            throw new BanelingException();
        }

        public override int Size
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

        public override string SourceColumn
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

        public override bool SourceColumnNullMapping
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

        public override DataRowVersion SourceVersion
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

        public override object Value
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
