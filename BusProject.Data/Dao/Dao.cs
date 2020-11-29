namespace BusProject.Data
{
    public class Dao
    {
        public static ReservationDao Reservation = new ReservationDao();
        
        public static CustomerDao Customer = new CustomerDao();

        public static RouteDao Route = new RouteDao();

    }
}