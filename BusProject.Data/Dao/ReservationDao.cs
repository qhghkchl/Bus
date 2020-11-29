using System;
using System.Linq;
using System.Linq.Expressions;
using EFLibrary;


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

        public Reservation GetByReservationId(int reservationId)
        {
            using (var context = new BusProjectEntities())
            {
                return context.Reservations.FirstOrDefault(x => x.ReservationId == reservationId);
            }
        }
    }
}