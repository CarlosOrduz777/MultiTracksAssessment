CREATE PROCEDURE dbo.GetArtistByName
	@name varchar(100) = ''
AS
BEGIN
	SELECT * FROM dbo.Artist WHERE title LIKE CONCAT('%', @name, '%');
END