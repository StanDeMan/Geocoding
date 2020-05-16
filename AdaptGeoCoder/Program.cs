using System;
using System.Linq;
using System.Threading.Tasks;
using Geocoding;
using Geocoding.Here;

namespace AdaptGeoCoder
{
	internal class Program
    {
        static async Task Main()
        {
	        IGeocoder geoCoder = new HereGeocoder("TyWb0B0I1ZcbQdgU7SlHSyD3UAO7JgIkxsSjibEUP1U");
	        var addresses = await geoCoder.GeocodeAsync("79350 Sexau Am Löwengarten 12");
	        var addressList = addresses?.ToList();

	        Console.WriteLine("Formatted: " + addressList?.First().FormattedAddress); 
	        Console.WriteLine("Coordinates: " + addressList?.First().Coordinates.Latitude + ", " + addressList?.First().Coordinates.Longitude); 
            Console.WriteLine();

	        addresses = await geoCoder.GeocodeAsync("Sexau Am Löwengarten 12");
	        addressList = addresses?.ToList();

	        Console.WriteLine("Formatted: " + addressList?.First().FormattedAddress); 
	        Console.WriteLine("Coordinates: " + addressList?.First().Coordinates.Latitude + ", " + addressList?.First().Coordinates.Longitude); 
	        Console.WriteLine();

	        addresses = await geoCoder.GeocodeAsync("79098 Freiburg");
	        addressList = addresses?.ToList();

	        Console.WriteLine("Formatted: " + addressList?.First().FormattedAddress); 
	        Console.WriteLine("Coordinates: " + addressList?.First().Coordinates.Latitude + ", " + addressList?.First().Coordinates.Longitude); 
	        Console.WriteLine();

	        addresses = await geoCoder.GeocodeAsync("Am Löwengarten 12 Sexau");
	        addressList = addresses?.ToList();

	        Console.WriteLine("Formatted: " + addressList?.First().FormattedAddress); 
	        Console.WriteLine("Coordinates: " + addressList?.First().Coordinates.Latitude + ", " + addressList?.First().Coordinates.Longitude); 
	        Console.WriteLine();

	        addresses = await geoCoder.GeocodeAsync("Newcastle");
	        addressList = addresses?.ToList();

	        if (addressList != null)
	        {
		        foreach (var address in addressList)
		        {
			        Console.WriteLine("Formatted: " + address?.FormattedAddress);
			        Console.WriteLine("Coordinates: " + address?.Coordinates.Latitude + ", " +
			                          address?.Coordinates.Longitude);
			        Console.WriteLine();
		        }
	        }

	        addresses = await geoCoder.ReverseGeocodeAsync(48.10506, 7.90862);
	        addressList = addresses?.ToList();

	        Console.WriteLine("Formatted: " + addressList?.First().FormattedAddress); 
	        Console.WriteLine("Coordinates: " + addressList?.First().Coordinates.Latitude + ", " + addressList?.First().Coordinates.Longitude); 
			Console.WriteLine();

	        Console.WriteLine("Press Enter!");
	        Console.ReadKey();
        }
    }
}
