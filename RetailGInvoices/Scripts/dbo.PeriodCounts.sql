CREATE VIEW [dbo].[PeriodCounts]
	AS SELECT CompanyId, count(CompanyId) as Count FROM [dbo].[Period] group by CompanyId