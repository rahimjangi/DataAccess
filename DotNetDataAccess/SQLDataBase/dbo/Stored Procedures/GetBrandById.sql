CREATE  PROCEDURE [dbo].[GetBrandById]
	(@CategoryID int)
AS
BEGIN
	set nocount on
	SELECT * FROM [dbo].[Brand]
	WHERE [Brand].[CategoryID]=@CategoryID
END
