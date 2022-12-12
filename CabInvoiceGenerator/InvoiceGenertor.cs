using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenertor
    {
        RideType objRideType;
        private RideRepository objRideRepository;
        private readonly double MIN_COST_PER_KM;
        private readonly int COST_PER_TIME;
        private readonly double MIN_FARE;
        public InvoiceGenertor(RideType objRideType)
        {
            this.objRideType = objRideType;
            this.objRideRepository = objRideRepository;
            try
            {
                if(objRideType.Equals(RideType.PREMIUM))
                {
                    this.MIN_COST_PER_KM = 15;
                    this.COST_PER_TIME = 2;
                    this.MIN_FARE = 20;
                }
                else if(objRideType.Equals(RideType.NORMAL))
                {

                }
            }
            catch(CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDE_TYPE,"Invalid Ride Type");
            }
        }
    }
}
