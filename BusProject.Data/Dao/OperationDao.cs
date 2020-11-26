using System;
using System.Linq;
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

        public Route GetArrival(int routeId)
        {
            using (var context = new BusProjectEntities())
            {
                return context.Routes.FirstOrDefault(x => x.RouteId == routeId);
            }
        }
    }
}