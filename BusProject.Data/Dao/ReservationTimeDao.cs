using System;
using System.Linq;
using System.Linq.Expressions;
using EFLibrary;
using System.Collections.Generic;

namespace BusProject.Data
{
    public class ReservationTimeDao : SingleKeyDao<ReservationTime, int>
    {
        protected override Expression<Func<ReservationTime, bool>> IsKey(int key)
        {
            return x => x.ReservationTimeId == key;
        }

        protected override Expression<Func<ReservationTime, int>> KeySelector
        {
            get
            {
                return x => x.ReservationTimeId;
            }
        }

        public List<ReservationTime> ReservationRouteId()
        {
            using (var context = new BusProjectEntities())
            {
                var query = from x in context.ReservationTimes
                            select new { ReservationTime = x, RouteId = x.RouteId };
                var list = query.ToList();

                foreach (var item in list)
                {
                    item.ReservationTime.RouteId = item.RouteId;
                }
                return list.ConvertAll(x => x.ReservationTime);
            }
        }

        public ReservationTime GetByReservationId(int reservationTimeId)
        {
            using (var context = new BusProjectEntities())
            {
                return context.ReservationTimes.FirstOrDefault(x => x.ReservationTimeId == reservationTimeId);
            }
        }

        public static List<ReservationTime> GetAllReservationDate()
        {
            using (var context = new BusProjectEntities())
            {
                return context.ReservationTimes.ToList();
            }
        }
    }
}
