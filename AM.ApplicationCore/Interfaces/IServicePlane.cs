using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IservicePlane:IService<Plane>
    {
        public IEnumerable<Passenger> GetPassengersByFlight(Plane p);
        public void DeletePlanes();
        public IList<Flight> GetLatestFlights(int n, Plane p);


    }
}
