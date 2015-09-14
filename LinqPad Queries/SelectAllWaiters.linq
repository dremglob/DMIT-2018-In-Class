<Query Kind="Expression">
  <Connection>
    <ID>b38d3340-8350-4a56-822d-2a6e276ce2b3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from data in Waiters
where data.ReleaseDate == null
select data