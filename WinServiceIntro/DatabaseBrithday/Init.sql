if not exists (select top(1)0 from [Status])
begin 
insert into [dbo].[Status]
([Name])
values
(N'Gözləmədədir'),(N'Göndərilib')
end