using System;
using System.Linq;
using System.Linq.Expressions;
using EFLibrary;
using System.Data.SqlClient;
using System.Collections.Generic;

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
        public Route GetByRouteId(int routeId)
        {
            using (var context = new BusProjectEntities())
            {
                return context.Routes.FirstOrDefault(x => x.RouteId == routeId);
            }
        }     

        public List<string> GetDepartureCities(object dataSource)
        {
            using (var context = new BusProjectEntities())
            {
                return context.Routes.Select(x => x.Departure).ToList();
            }
        }

        public List<string> GetArrivalCities(object dataSource)
        {
            using (var context = new BusProjectEntities())
            {
                return context.Routes.Select(x => x.Arrival).ToList();
            }
        }
    }
}
