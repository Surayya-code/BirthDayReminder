CREATE PROCEDURE [dbo].[spChangeStatus]
	@id int
AS
	begin
	update [dbo].[Persons]
    set [StatusId]=2,SendDate=dateadd(hour,4,getutcdate())
   where [Id]=@id
	end
