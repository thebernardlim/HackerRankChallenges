USE [hackerrank]
GO

--INSERT INTO [dbo].[thepads] VALUES ('A', 'Doctor')
--INSERT INTO [dbo].[thepads] VALUES ('B', 'Actor')
--INSERT INTO [dbo].[thepads] VALUES ('C', 'Actor')
--INSERT INTO [dbo].[thepads] VALUES ('D', 'Singer')
--INSERT INTO [dbo].[thepads] VALUES ('E', 'Professor')
--INSERT INTO [dbo].[thepads] VALUES ('F', 'Professor')
--INSERT INTO [dbo].[thepads] VALUES ('G', 'Professor')
--INSERT INTO [dbo].[thepads] VALUES ('H', 'Actor')
--INSERT INTO [dbo].[thepads] VALUES ('I', 'Doctor')
--INSERT INTO [dbo].[thepads] VALUES ('J', 'Singer')

SELECT FORMATMESSAGE('%s(%s)', occ.Name, LEFT(occ.Occupation, 1) )
FROM dbo.Occupations occ
ORDER BY occ.Name ASC

SELECT FORMATMESSAGE('There are a total of %d %ss.', COUNT(occ.Occupation), LOWER(occ.Occupation))
FROM dbo.Occupations occ
GROUP BY occ.Occupation
ORDER BY COUNT(occ.Occupation), occ.Occupation ASC


