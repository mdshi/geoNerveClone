using CensusAPIService;
using CensusAPIService.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDriver
{
    class Program
    {
        public static List<Address> geocodedAddressList { get; private set; }

        static void Main(string[] args)
        {
            BulkApiAgent _apiAgent = new BulkApiAgent();
         

            var testAddressList = new List<Address>
            {
                Address.ParseAddressFromCsv("1,667 Massachusetts Avenue,Cambridge,MA,02139"),
                Address.ParseAddressFromCsv("2,30 Tyler Street,Boston,MA,02111"),
                Address.ParseAddressFromCsv("3,216 Norfolk Street,Cambridge,MA,02139"),
                Address.ParseAddressFromCsv("4,88 Brattle Street,Cambridge,MA,02133"),
                Address.ParseAddressFromCsv("5,688 Concord Avenue,Belmont,MA,02478"),
            };

            var result = _apiAgent.BulkGeocode(testAddressList);
            CensusGeolocator geoLocator = new CensusGeolocator();
            geocodedAddressList = geoLocator.GeoCodeObjects(testAddressList);


               Console.WriteLine(geocodedAddressList);
            geocodedAddressList.ForEach(i => Console.Write("{0}\t", i));

            // var addresses = new List<Address>();
           // var apiAgent = new BulkApiAgent();
          // var test = apiAgent.BulkGeocode(testAddressList);
            
          //Console.WriteLine(test);
           // test.ForEach(i => Console.WriteLine("{0}\t", i));

       
           // string csv = String.Join(",", test.Select(x => x.ToString()).ToArray());

          //  Console.WriteLine(csv.ToString());
            
            //result.ToString();

        }
    }
}
