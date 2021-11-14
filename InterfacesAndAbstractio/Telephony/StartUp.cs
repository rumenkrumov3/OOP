using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        public static void Main()
        {

            List<string> phones = Console.ReadLine().Split().ToList();
            List<string> websites = Console.ReadLine().Split().ToList();

            for (int i = 0; i < phones.Count; i++)
            {
                StationaryPhone sm = new StationaryPhone(phones[i]);
                Smartphone sp = new Smartphone();
                sp.Phone = phones[i];
                if(sm.Phone != null && sm.Phone.Length == 7)
                {
                    sm.CallingOtherPhone(sm.Phone);
                }
                else if(sp.Phone != null && sp.Phone.Length == 10)
                {
                    sp.CallingOtherPhone(sp.Phone);
                }

            }

            for (int i = 0; i < websites.Count; i++)
            {
                Smartphone sm = new Smartphone(websites[i]);
                if(sm.Website != null)
                {
                    sm.BrowseWebSite(sm.Website);
                }
                
            }
        }
    }
}
