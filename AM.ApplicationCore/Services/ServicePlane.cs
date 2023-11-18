using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane : Service<Plane>, IServicePlane
    {
        public ServicePlane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }


        public void DeletePlanes()
        {
            Delete(p=>(DateTime.Now.Year - p.ManufactureDate.Year)>10);
        }

        IEnumerable<Passenger> GetPassengersByFlight(Plane p)
        {
            return p.Flights.SelectMany(f => f.Passengers);
        }


        public IList<Flight> GetLatestFlights(int n,Plane p)
        {
            return p.Flights.OrderByDescending(f => f.FlightDate).Take(n).ToList();
        }

        public bool CanReserveSeats(int n, Flight f )
        {
            return t.plane.capacity >= t.passenger.count() + n;
        }

       
    }

    
}

