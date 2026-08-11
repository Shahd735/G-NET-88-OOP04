using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_OOP_4
{
    public class ExpressShipment : Shipment
    {
        private decimal _extraFee;

        public decimal ExtraFee
        {
            get { return _extraFee; }
            set
            {
                if (value >= 0)
                {
                    _extraFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + ExtraFee;
            }
        }

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee >= 0 ? extraFee : 0;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("--- Express Shipment ---");
            base.PrintShipment();
            Console.WriteLine($"Extra Fee: {ExtraFee}");
        }
    }
}
