using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballers_API.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/bookingAPI")]
[ApiController]
public class BookingController : ControllerBase
{
    [HttpGet]

    public IEnumerable<Booking> GetBookings()
    {
        return new List<Booking>
        {
           // new Booking(1, 1, DateTime.Now.AddHours(6), DateTime.Now),
            //new Booking(2, 1, DateTime.Now.AddHours(12), DateTime.Now)
        };
    }
}


