using System;

public class Booking
{
	public int Id { get; set; }
	public DateTime OrderTime { get; set; }

    // Time of Event
    public DateTime EventTime { get; set; }

	// duration of booking in hours
	public float Duration { get; set; }

    // Id of user who made the booking
    public int BookerId { get; set; } 

	public Booking(int id, DateTime orderTime, DateTime eventTime, float duration, int bookerId)
    {
		Id = id;
        OrderTime = DateTime.Now;
        EventTime = eventTime;
        Duration = duration;
		BookerId = bookerId;
    }


}