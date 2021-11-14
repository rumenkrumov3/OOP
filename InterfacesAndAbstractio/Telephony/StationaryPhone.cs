using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : IStationaryPhone
    {
        private string phone;
        public StationaryPhone(string phone)
        {
            this.Phone = phone;
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            private set
            {
                bool flag = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsLetter(value[i]))
                    {
                        Console.WriteLine("Invalid number!");
                        flag = true;
                        break;
                    }
                }
                if (flag != true)
                {
                    this.phone = value;
                }
            }
        }

        public void CallingOtherPhone(string phoneNumber)
        {

             Console.WriteLine($"Dialing... {phoneNumber}");

        }
    }
}
