namespace BusProject.Data
{
    public class Dao
    {
        public static OperationDao Operation { get; } = new OperationDao();
        
        public static CustomerDao Customer { get; }  = new CustomerDao();

        public static RouteDao Route { get; }  = new RouteDao();

        public static ReservationDao Reservation { get; }  = new ReservationDao();

    }
}