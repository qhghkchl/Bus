using System;
using System.Linq;
using System.Linq.Expressions;
using EFLibrary;
using System.Collections.Generic;


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

        public List<Operation> GetByOperationId (int operationId)
        {
            using (var context = new BusProjectEntities())
            {
                var query = from x in context.Operations
                            where x.OperationId == operationId
                            select x;

                return query.ToList();
            }
        }

        
    }
}