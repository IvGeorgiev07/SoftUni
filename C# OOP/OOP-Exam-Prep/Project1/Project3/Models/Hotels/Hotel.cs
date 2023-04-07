using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Hotels.Contacts;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories.Contracts;
using BookingApp.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Models.Hotels
{
    internal class Hotel : IHotel
    {
        public Hotel(string fullName, int category)
        {
            FullName= fullName;
            Category= category;
        }
        private string fullName;
        public string FullName
        {
            get { return fullName; }
            private set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.HotelNameNullOrEmpty);
                }
                fullName = value;
            }
        }

        private int category;

        public int Category
        {
            get { return category; }
            private set
            { 
                if(value < 1 || value > 5)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCategory);
                }
                category = value;
            }
        }

        private double turnover;

        public double Turnover => Math.Round(Bookings.All().Sum(x=>x.ResidenceDuration * x.Room.PricePerNight),2);


        private IRepository<IRoom> rooms;
        public IRepository<IRoom> Rooms
        {
            get { return rooms; }
            private set { rooms = value; }
        }

        private IRepository<IBooking> bookings;
        public IRepository<IBooking> Bookings
        {
            get { return bookings; }
            private set { bookings = value; }
        }
    }
}
