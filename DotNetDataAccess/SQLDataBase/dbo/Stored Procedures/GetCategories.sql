CREATE PROCEDURE [dbo].[GetCategories]

AS
BEGIN
	set nocount on
	SELECT * FROM [dbo].[Categories]
END