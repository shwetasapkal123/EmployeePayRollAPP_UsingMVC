/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
      ,[DisplayOrder]
      ,[CreatedDateTime]
  FROM [Bulky].[dbo].[categories]

  insert into categories (Name, DisplayOrder,CreatedDateTime)
  values('snehal',54,'2022-11-2')

  select * from categories