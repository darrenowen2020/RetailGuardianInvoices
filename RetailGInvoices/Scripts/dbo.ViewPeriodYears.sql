CREATE VIEW [dbo].[ViewPeriodYears]
	AS SELECT YearNo FROM dbo.Period group by YearNo;