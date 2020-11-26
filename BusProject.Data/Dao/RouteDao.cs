using System;
using System.Linq;
using System.Linq.Expressions;
using EFLibrary;
using System.Data.SqlClient;

namespace BusProject.Data
{
    public class RouteDao : SingleKeyDao<Route, int>
    {
        protected override Expression<Func<Route, bool>> IsKey(int key)
        {
            return x => x.RouteId == key;
        }

        protected override Expression<Func<Route, int>> KeySelector
        {
            get
            {
                return x => x.RouteId;
            }
        }
        public Route GetArrival(int routeId)
        {
            using (var context = new BusProjectEntities())
            {
                return context.Routes.FirstOrDefault(x => x.RouteId == routeId);
            }
        }

        public Route GetLocation(Route routeId)
        {
            using (var context = new BusProjectEntities())
            {
               context.Routes.Find(routeId);
               context.SaveChanges();
               return routeId;
            }
        }

        public string GetArrival(bool v) // 창준 수정 
        {
            throw new NotImplementedException();
        }
    }
}
