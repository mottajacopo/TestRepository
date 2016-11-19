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

        static private GSM samsungGalaxyS7 = new GSM("Samsung Galaxy S7", "Samsung", "Pippo", 800, new Battery("3000mAh", 100, 22), new Display(5.2f, 16000000));

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


        public Call[] callList;
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
        }

        public float CallPrice(int oneMinutePrice)
        {
            float price = 0;

            for (int i = 0; i < counter; i++)
            {
                price += this.callList[i].Duration * oneMinutePrice;
            }

            return price;
        }
    }
}