<Query Kind="Program">
  <Connection>
    <ID>e9e19a32-0805-4c6c-865a-4efcee78c994</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

void Main()
{
	var students = Names();
	//students.Dump();
	
	var lastInitial_S = from person in students
						where person.Contains(" S")
						select person;
	lastInitial_S.Dump("People whose last name starts with 'S'");
}

// Define other methods and classes here
public List<string> Names()
{
	List<string> data = new List<string>();
	data.Add("Bob Saunders");
	data.Add("Shawn Drem");
	data.Add("Don Welch");
	data.Add("Ash Ketchum");
	
	return data;
}