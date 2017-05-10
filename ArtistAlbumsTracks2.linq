<Query Kind="Statements">
  <Connection>
    <ID>ccfc27c1-0e99-4f29-84d1-f03d4433550e</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from a in Artists
              where a.ArtistId == 1
             orderby a.Name
			 select new
			 {
			   Artist = a.ArtistId,
			   Albums = from t in a.Albums
			            orderby t.Title
						select new
				{
				    Title = t.Title,
					Tracks = from tr in t.Tracks
					         select new
					{
					    TrackName = tr.Name,
						Genre = tr.Genre.Name,
						MediaType = tr.MediaType.Name,
						Composer = tr.Composer,
						Milliseconds = tr.Milliseconds
					}
				}
			 };
results.Dump();