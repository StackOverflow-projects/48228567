
-- Data Table 
	CREATE SCHEMA DF
	GO

	CREATE TABLE [DF].[Sample](
		[Number] [nvarchar](40) NOT NULL,
		[Name] [nvarchar](255) NULL,
		[Abbr Name] [nvarchar](50) NULL
	) ON [PRIMARY]  
	GO

-- Populate Table with Sample Data
	declare
	@i_index as int
	,@i_count as int

	Select @i_index = 1, @i_count = 1100

	while @i_index < @i_count
	begin

		insert into DF.[Sample]([Number],[Name],[Abbr Name])
		select @i_index, 'N' + CAST(@i_index as nvarchar), 'A' + CAST(@i_index as nvarchar)

		select @i_index = @i_index + 1
	end
GO
-- Stored Procedure (called by UI)

	CREATE procedure [df].[UI searchEntity](
		@SearchText nvarchar(128) = ''
	)
	as
	set nocount on 

	select @SearchText = '%' + @SearchText + '%';

	select  [Number] as [EntityID], [Name] as [EntityName], isnull([Abbr Name],'') as [AbbrName]
	 from df.[Sample]
	 where 
		[Name] like @searchText
		OR
		[Abbr Name] like @searchText
	order by [Abbr Name]

GO