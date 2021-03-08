using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvities.Models
{
    public class Repository
    {
        private static List<GuestResponce> responces = new List<GuestResponce>();
        public static IEnumerable<GuestResponce> Responces => responces;
        public static void AddResponse(GuestResponce responce)
        {
            responces.Add(responce);
        }
    }
}
