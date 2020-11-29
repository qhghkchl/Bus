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

        public Operation GetByReservationId(int operationId)
        {
            using (var context = new BusProjectEntities())
            {
                return context.Operations.FirstOrDefault(x => x.OperationId == operationId);
            }
        }

/*        public List<string> JoinWithRoute(string routeId, string join)
        {
            using (var context = new BusProjectEntities())
            {
*//*                join = @"Select Route"
*//*            }
        }
*/    }
}