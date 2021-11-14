using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ISmartpone
    {
        private string phone;
        private string website;

        public Smartphone()
        {

        }
        public Smartphone(string phone, string website)
        {
            this.Phone = phone;
            this.Website = website;
        }
        public Smartphone(string website)
        {
            this.Website = website;
        }
        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
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

        public string Website
        {
            get
            {
                return this.website;
            }
            private set
            {
                bool flag = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]))
                    {
                        Console.WriteLine("Invalid URL!");
                        flag = true;
                        break;
                    }
                }
                if (flag != true)
                {
                    this.website = value;
                }
            }
        }

        public void BrowseWebSite(string webSite)
        {
            Console.WriteLine($"Browsing: {webSite}!");
        }

        public void CallingOtherPhone(string phoneNumber)
        {
            Console.WriteLine($"Calling... {phoneNumber}");
        }
    }
}
