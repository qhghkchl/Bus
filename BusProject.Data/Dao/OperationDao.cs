using System;
using System.Linq.Expressions;
using EFLibrary;

namespace BusProject.Data
{
    public class OperationDao : SingleKeyDao<Operation, int>
    {
        protected override Expression<Func<Operation, bool>> IsKey(int key)
        {
            return x => x.OperationId == key;
        }

        protected override Expression<Func<Operation, int>> KeySelector
        {
            get
            {
                return x => x.OperationId;
            }
        }
    }
}