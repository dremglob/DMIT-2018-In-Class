<Query Kind="Expression" />

//booking is a variable name that I made up
from booking in Reservations
where booking.EventCode.Equals("A")
select booking