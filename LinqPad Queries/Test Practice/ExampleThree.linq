<Query Kind="Expression">
  <Connection>
    <ID>cee0ea4f-7b91-4a58-abc6-73db6b1af435</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from served in Bills
where served.OrderServed == null
select served