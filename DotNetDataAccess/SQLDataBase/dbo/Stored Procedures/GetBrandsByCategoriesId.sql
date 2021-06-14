CREATE PROCEDURE [dbo].[GetBrandsByCategoriesId]
	@CategoryId INT
AS
BEGIN
	set nocount on
	SELECT * FROM [dbo].[Brand]
	WHERE [Brand].[CategoryID]=@CategoryId
END
