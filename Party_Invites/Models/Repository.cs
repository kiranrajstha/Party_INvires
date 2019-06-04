using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Party_Invites.Models
{
    public class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>() ;

        public static IEnumerable<GuestResponse> Reponses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
