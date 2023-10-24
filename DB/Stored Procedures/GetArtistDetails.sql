CREATE PROCEDURE dbo.GetArtistDetails
	@artistId INT
AS
BEGIN

	SELECT TOP 3
		Song.title SongTitle, 
		Song.bpm, 
		Song.multitracks, 
		Song.customMix, 
		Song.rehearsalMix, 
		Song.songSpecificPatches, 
		Song.chart, 
		Song.proPresenter,
		Album.title AlbumTitle,
		Album.imageURL AlbumImage
	FROM dbo.Song 
	inner join dbo.Album on Song.albumID = Album.albumID
	WHERE Song.artistID = @artistId and Album.artistID = @artistId

	SELECT 
		Album.title, Album.imageURL 
	FROM dbo.Album
	WHERE Album.artistID = @artistId

	SELECT 
		title, biography, imageURL, heroURL 
	FROM dbo.Artist
	WHERE Artist.artistID = @artistId
END