using System;
using System.Linq;
using System.Linq.Expressions;
using EFLibrary;
using System.Collections.Generic;

namespace BusProject.Data
{
    public class CustomerDao : SingleKeyDao<Customer, int>
    {
        protected override Expression<Func<Customer, bool>> IsKey(int key)
        {
            return x => x.CustomerId == key;
        }

        protected override Expression<Func<Customer, int>> KeySelector
        {
            get
            {
                return x => x.CustomerId;
            }
        }

        public Customer GetByLogid(string loginId)
        { 
            using (var context = new BusProjectEntities())
            {
                return context.Customers.FirstOrDefault(x => x.LoginId == loginId);
            }
        }

        public List<Customer> GetManReservation()
        {
            using (var context = new BusProjectEntities())
            {
                var query = from x in context.Customers
                            select x;

                List<Customer> customers = query.ToList();

                foreach (Customer customer in customers)
                {
                    Seat seat = context.Seats.FirstOrDefault(x => x.CustomerId == customer.CustomerId);
                    customer.SeatColumn = seat.SeatColumn;
                    customer.SeatColumnNumber = seat.SeatColumnNumber;
                    customer.PaymentMethod = seat.PaymentMethod;

                    Operation operation = context.Operations.FirstOrDefault(x => x.OperationId == seat.OperationId);
                    customer.DepartureLocation = operation.DepartureLocation;
                    customer.ArrivalLocation = operation.ArrivalLocation;
                    customer.OperationDate = operation.OperationDate;
                   
                    //customer.DepartureTime = operation.DepartureTime;
                    
                    Route route = context.Routes.FirstOrDefault(x => x.RouteId == operation.RouteId);
                    customer.BusTypeId = route.BusTypeId;

                    Reservation reservation = context.Reservations.FirstOrDefault(x => x.RouteId == route.RouteId);
                    customer.ReservationDate = reservation.ReservationDate;
                }
                return customers;
            }
        }
    }
}