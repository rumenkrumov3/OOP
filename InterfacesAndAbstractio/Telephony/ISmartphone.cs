using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ISmartpone
    {
        public void CallingOtherPhone(string number);

        public void BrowseWebSite(string website);
    }
}
