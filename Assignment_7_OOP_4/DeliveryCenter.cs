using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_OOP_4
{
    public class DeliveryCenter
    {
        public Driver CenterDriver { get; set; }
        public string CenterName { get; set; }

        private Shipment[] _shipments;

        public DeliveryCenter()
        {
            CenterName = "Main Delivery Center";
            _shipments = new Shipment[20];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < 20)
                    return _shipments[index];

                return null;
            }
            set
            {
                if (index >= 0 && index < 20)
                    _shipments[index] = value;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < 20; i++)
                {
                    if (_shipments[i] != null && _shipments[i].TrackingCode == trackingCode)
                        return _shipments[i];
                }
                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < 20; i++)
            {
                if (_shipments[i] == null)
                {
                    _shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < 20; i++)
            {
                if (_shipments[i] != null && _shipments[i].TrackingCode == trackingCode)
                {
                    _shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            bool isEmpty = true;

            for (int i = 0; i < 20; i++)
            {
                if (_shipments[i] != null)
                {
                    _shipments[i].PrintShipment();
                    isEmpty = false;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine("No shipments found in the center.");
            }
        }
    }
}
