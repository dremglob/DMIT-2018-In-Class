<Query Kind="Expression">
  <Connection>
    <ID>e9e19a32-0805-4c6c-865a-4efcee78c994</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from food in Items
group food by new {food.MenuCategoryID, food.CurrentPrice}
///no need for select if just grouping everything