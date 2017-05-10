<Query Kind="Statements">
  <Connection>
    <ID>ccfc27c1-0e99-4f29-84d1-f03d4433550e</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              orderby g.Name
			  select new
			  {
			     Genre = g.Name,
				 TracksCount = g.Tracks.Count()
			  
			  };
results.Dump("Query Math");