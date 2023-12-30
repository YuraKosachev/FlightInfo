using FlightInfo.Common.Enums;
using FlightInfo.Common.Interfaces.Providers;
using FlightInfo.Common.Interfaces.Services;
using FlightInfo.Common.Mappers;
using FlightInfo.Common.Models.Request;
using FlightInfo.Common.Models.Response;
using FlightInfo.Common.Models.View;
using System.Threading.Tasks;

namespace FlightInfo.Logic.Services
{
    public class FlightService : IFlightService
    {
        private readonly IAirportInfoByNameApiProvider _airportInfoByNameProvider;
        public FlightService(IAirportInfoByNameApiProvider airportInfoByNameProvider)
        {
            _airportInfoByNameProvider = airportInfoByNameProvider;
        }
        public Task<AirportInfo> GetAirportInfoByNameAsync(AirportInfoRequest request)
        {
            return _airportInfoByNameProvider.GetAirportInfoByNameAsync(request);
        }

        public async Task<AirportDistanceViewModel> GetAirportsDistance(AirportInfoRequest from, AirportInfoRequest to, DistanceUnitMeasuare distanceUnitMeasuare)
        {
            var infoFrom = await _airportInfoByNameProvider.GetAirportInfoByNameAsync(from);
            var infoTo = await _airportInfoByNameProvider.GetAirportInfoByNameAsync(to);

            return infoFrom.MapToDistance(infoTo, distanceUnitMeasuare);

        }
    }
}
