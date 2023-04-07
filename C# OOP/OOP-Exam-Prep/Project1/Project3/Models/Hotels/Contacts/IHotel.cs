namespace BookingApp.Models.Hotels.Contacts
{
    using BookingApp.Repositories.Contracts;
    using global::BookingApp.Models.Bookings.Contracts;
    using global::BookingApp.Models.Rooms.Contracts;
    using System.Collections.Generic;
    public interface IHotel
    {
        string FullName { get; }
        int Category { get; }
        double Turnover { get; }

        public IRepository<Rooms.Contracts.IRoom> Rooms { get; }
        public IRepository<Bookings.Contracts.IBooking> Bookings { get; }
    }
}
