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
where food.MenuCategory.Description == "Entree"
	|| food.MenuCategory.Description == "Beverage"
orderby food.CurrentPrice descending
group food by food.MenuCategoryID into result
select result
// list all the menu items that are entrees ordered by descending in cost