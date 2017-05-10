<Query Kind="Statements">
  <Connection>
    <ID>ccfc27c1-0e99-4f29-84d1-f03d4433550e</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
			  select new
			  {
			      Name = m.Name,
				  Tracks = from t in m.Tracks
				           select new
				{
				   TrackName = t.Name,
				   Album = t.AlbumId,
				   Genre = t.GenreId
				}
			
			  
			 };
results.Dump();