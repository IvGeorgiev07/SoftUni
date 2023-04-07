using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Models.Rooms;
using BookingApp.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Models.Bookings
{
    public class Booking : IBooking
    {
        public Booking(IRoom room, int residenceDuration, int adultsCount, int childrenCount, int bookingNumber)
        {
            Room = room;
            ResidenceDuration= residenceDuration;
            AdultsCount= adultsCount;
            ChildrenCount= childrenCount;
            BookingNumber= bookingNumber;
        }

        private IRoom room;
        public IRoom Room
        {
            get { return room; }
            private set { room = value; }
        }

        private int residenceDuration;
        public int ResidenceDuration
        {
            get { return residenceDuration; }
            private set 
            { 
                if(residenceDuration < 1)
                {
                    throw new ArgumentException(ExceptionMessages.DurationZeroOrLess);
                }
                residenceDuration = value;
            }
        }

        private int adultsCount;
        public int AdultsCount
        {
            get { return adultsCount; }
            private set 
            { 
                if(value < 1)
                {
                    throw new ArgumentException(ExceptionMessages.AdultsZeroOrLess);
                }
                adultsCount = value; 
            }
        }

        private int childrenCount;
        public int ChildrenCount
        {
            get { return childrenCount; }
            private set 
            {
                if (value < 1)
                {
                    throw new ArgumentException(ExceptionMessages.ChildrenNegative);
                }
                childrenCount = value;
            }
        }

        private int bookingNumber;
        public int BookingNumber
        {
            get { return bookingNumber; }
            private set { bookingNumber = value; }
        }

        public string BookingSummary()
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"Booking number: {BookingNumber}");
            sb.AppendLine($"Room type: {Room.GetType().Name}");
            sb.AppendLine($"Adults: {AdultsCount}");
            sb.AppendLine($"Children: {ChildrenCount}");
            sb.AppendLine($"Total amount paid: {TotalPaid():F2}$");
            return sb.ToString().Trim();

            
        }
        private double TotalPaid()
                => Math.Round(ResidenceDuration * Room.PricePerNight, 2);
    }
}
