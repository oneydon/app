using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ResBookAppLibrary1
{
    public class Reservation
    {
        public string HostName {  get; set; }
        public string ResturantName { get; set; }
        public string Datetime { get; set; }
        public  string PartySize { get; set; }
        public string DennyArea { get; set; }
        public string Occasion { get; set; }
        public int PhoneNumber {  get; set; }

        public Reservation() { }
        public Reservation(string hostName, string resturantName, string datetime, string partySize, string dennyArea, string occasion, int phoneNumber)
        {
            HostName = hostName;
            ResturantName = resturantName;
            Datetime = datetime;
            PartySize = partySize;
            DennyArea = dennyArea;
            Occasion = occasion;
            PhoneNumber = phoneNumber;
        }
    }
}
