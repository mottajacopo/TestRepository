using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_01
{
    public class GSM
    {
        private string model = null;
        private string manufacturer = null;
        private string owner = null;
        private int price = 0;
        private Battery battery = null;
        private Display display = null;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public GSM(string phoneModel, string manufacturer, string owner, int price, string batteryModel, int talkTime, int idleTime, float inches, decimal colors, Technology type = Technology.LiIon)
        {
            this.Model = phoneModel;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = new Battery(batteryModel, talkTime, idleTime, type);
            this.display = new Display(inches, colors);
        }
        public GSM(string phoneModel, string manufacturer, string owner, int price, Battery battery, Display display)
            : this(phoneModel, manufacturer, owner, price, battery.Model, battery.TalkTime, battery.IdleTime, display.Inches, display.Colors, Technology.LiIon)
        {
        }
        public GSM(string phoneModel, string manufacturer, string owner, int price, string batteryModel, int talkTime, int idleTime, float inches, decimal colors)
            : this(phoneModel, manufacturer, owner, price, batteryModel, talkTime, idleTime, inches, colors, Technology.LiIon)
        {
        }
        public GSM(string phoneModel, string manufacturer, string owner, int price, string batteryModel, int talkTime, int idleTime, float inches)
           : this(phoneModel, manufacturer, owner, price, batteryModel, talkTime, idleTime, inches, 0, Technology.LiIon)
        {
        }
        public GSM(string phoneModel, string manufacturer, string owner, int price, string batteryModel, int talkTime, int idleTime)
           : this(phoneModel, manufacturer, owner, price, batteryModel, talkTime, idleTime, 0, 0, Technology.LiIon)
        {
        }
        public GSM(string phoneModel, string manufacturer, string owner, int price, string batteryModel, int talkTime)
           : this(phoneModel, manufacturer, owner, price, batteryModel, talkTime, 0, 0, 0, Technology.LiIon)
        {
        }
        public GSM(string phoneModel, string manufacturer, string owner, int price)
         : this(phoneModel, manufacturer, owner, price, null, 0, 0, 0, 0, Technology.LiIon)
        {
        }
        public GSM(string phoneModel, string manufacturer, string owner)
           : this(phoneModel, manufacturer, owner, 0, null, 0, 0, 0, 0, Technology.LiIon)
        {
        }
        public GSM(string phoneModel, string manufacturer)
          : this(phoneModel, manufacturer, null, 0, null, 0, 0, 0, 0, Technology.LiIon)
        {
        }
        public GSM(string phoneModel)
          : this(phoneModel, null, null, 0, null, 0, 0, 0, 0, Technology.LiIon)
        {
        }
        public GSM()
         : this(null, null, null, 0, null, 0, 0, 0, 0, Technology.LiIon)
        {
        }

        static private GSM samsungGalaxyS7 = new GSM("Samsung Galaxy S7", "Samsung", "Pippo", 800, new Battery("3000mAh", 22, 120), new Display(5.2f, 16000000));

        public string[] PhoneInformation()
        {
            string[] info = new string[10];
            info[0] = "Model is : " + samsungGalaxyS7.Model;
            info[1] = "Manufacturer is : " + samsungGalaxyS7.Manufacturer;
            info[2] = "Owner is : " + samsungGalaxyS7.Owner;
            info[3] = "Price is : " + samsungGalaxyS7.Price;
            info[4] = "Battery size is : " + samsungGalaxyS7.battery.Model;
            info[5] = "Idle time is : " + samsungGalaxyS7.battery.IdleTime;
            info[6] = "Talk time is : " + samsungGalaxyS7.battery.TalkTime;
            info[7] = "Display size is : " + samsungGalaxyS7.display.Inches;
            info[8] = "Display colors are : " + samsungGalaxyS7.display.Colors;
           
            return info;
        }

        public Call[] callList = new Call[100];
        public int counter = 0;
        public void AddCall(string date, string startTime, int duration)
        {
            this.callList[counter] = new Call(date, startTime, duration);
            counter++;
        }
        public void RemoveCall(int index)
        {
            Call removed = this.callList[index];
            for (int i = index; i < counter - 1; i++)
            {
                this.callList[i] = this.callList[i + 1];
            }
            this.callList[counter - 1] = null;
            counter--;
        }

        public void ClearCallList()
        {
            for (int i = counter; i > -1; i--)
            {
                this.callList[i] = null;
            }
            counter = 0;
        }

        public float CallPrice(float oneMinutePrice)
        {
            float price = 0.0f;

            for (int i = 0; i < counter; i++)
            {
                price += this.callList[i].Duration * oneMinutePrice;
            }

            return price;
        }
    }
}