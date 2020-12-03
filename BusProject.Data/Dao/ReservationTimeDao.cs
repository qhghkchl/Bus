using System;
using System.Linq;
using System.Linq.Expressions;
using EFLibrary;
using System.Collections.Generic;

namespace BusProject.Data
{
    public class ReservationDao : SingleKeyDao<Reservation, int>
    {
        protected override Expression<Func<Reservation, bool>> IsKey(int key)
        {
            return x => x.ReservationId == key;
        }

        protected override Expression<Func<Reservation, int>> KeySelector
        {
            get
            {
                return x => x.ReservationId;
            }
        }

        public List<Reservation> ReservationRouteId()
        {
            using (var context = new BusProjectEntities())
            {
                var query = from x in context.Reservations
                            select new { Reservation = x, RouteId = x.RouteId };
                var list = query.ToList();

                foreach (var item in list)
                {
                    item.Reservation.RouteId = item.RouteId;
                }
                return list.ConvertAll(x => x.Reservation);
            }
        }

        public Reservation GetByReservationId(int reservationTimeId)
        {
            using (var context = new BusProjectEntities())
            {
                return context.Reservations.FirstOrDefault(x => x.ReservationId == reservationTimeId);
            }
        }

        public static List<Reservation> GetAllReservationDate()
        {
            using (var context = new BusProjectEntities())
            {
                return context.Reservations.ToList();
            }
        }
    }
}
