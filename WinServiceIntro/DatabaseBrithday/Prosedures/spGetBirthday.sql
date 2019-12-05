CREATE PROCEDURE [dbo].[spGetBirthday]
	
AS
	begin
	declare @thisday date=dateadd(HOUR,4,getutcdate())

		select [Name],[Surname],[Birthday],[Message],[Email]from [dbo].[Persons]
		where [StatusId]=1
		and MONTH(Birthday)=MONTH(@thisday)
		and Day(Birthday)=Day(@thisday)

	end

