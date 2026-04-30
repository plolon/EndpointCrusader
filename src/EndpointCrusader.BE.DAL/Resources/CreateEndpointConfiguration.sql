INSERT INTO [dbo].[endpoints] (
	[Name],
	[Url],
	[CreatedAt],
	[ModifiedAt]
) 
OUTPUT INSERTED.Id
VALUES (
	@Name,
	@Url,
	GETUTCDATE(),
	GETUTCDATE()
);