using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ballers_API.Models;

[Route("API/Bookings")]
[ApiController]
public class BookingsController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Booking> GetBookings()
    {

        var datetime = DateTime.Now;
        return new List<Booking>
        {
            new Booking(1, datetime, datetime.AddHours(5), datetime.AddHours(6), 50),
            new Booking(2, datetime, datetime.AddHours(24), datetime.AddHours(26), 60)
        };
    }
}