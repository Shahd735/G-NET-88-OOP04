using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_OOP_4
{
    public class InternationalShipment : Shipment
    {
        private string _destinationCountry;
        private decimal _customsFee;

        public string DestinationCountry
        {
            get { return _destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _destinationCountry = value;
                }
            }
        }

        public decimal CustomsFee
        {
            get { return _customsFee; }
            set
            {
                if (value >= 0)
                {
                    _customsFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + CustomsFee;
            }
        }

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = !string.IsNullOrWhiteSpace(destinationCountry) ? destinationCountry : "Unknown Country";
            CustomsFee = customsFee >= 0 ? customsFee : 0;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("--- International Shipment ---");
            base.PrintShipment();
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee}");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Standard Customs Report for {DestinationCountry}. Fee: {CustomsFee}");
        }
    }
}
