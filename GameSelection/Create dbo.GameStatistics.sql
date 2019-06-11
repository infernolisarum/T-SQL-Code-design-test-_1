USE [GameSelectionStatistics]
GO

/****** Object: Table [dbo].[GameStatistics] Script Date: 10.06.2019 19:35:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SELECT TeamName, GameDate, Score, AllScore
FROM (
	SELECT *, ROW_NUMBER() OVER (ORDER BY GameDate) AS RowNumber,
	SUM (Score) OVER (ORDER BY GameDate) AS AllScore
	FROM GameStatistics
) AS foo
WHERE RowNumber % 5 = 0;

--CREATE TABLE [dbo].[GameStatistics] (
--    [Id]       INT            IDENTITY (1, 1) NOT NULL,
--    [TeamName] NVARCHAR (MAX) NULL,
--    [GameDate] DATETIME2 (7)  NOT NULL,
--    [Score]    INT            NOT NULL
--);