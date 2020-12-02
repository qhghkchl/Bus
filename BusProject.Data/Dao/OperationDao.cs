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

        public List<Operation> GetWithRoute()
        {
            using (var context = new BusProjectEntities())
            {
                var query = from x in context.Operations 
                            select x;


                List<Operation> operations = query.ToList();


                //departure, arrival, bustype
                foreach (Operation operation in operations)
                {
                    //Route routes = context.Routes.First(x => x.RouteId == operation.RouteId);
                    Route route = context.Routes.SingleOrDefault( x => x.RouteId == operation.RouteId);
                    operation.DepartureLocation = route.DepartureLocation;
                    operation.ArrivalLocation = route.ArrivalLocation;
                    operation.BusTypeId = route.BusTypeId;
                }
                return operations;
            }
        }
    }
}