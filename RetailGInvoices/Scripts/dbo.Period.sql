CREATE TABLE [dbo].[Period] (
    [PeriodKey]        VARCHAR (5) NOT NULL,
    [PeriodNo]         INT         NOT NULL,
    [YearNo]           INT         NOT NULL,
    [StartDate]        DATE        NOT NULL,
    [EndDate]          DATE        NOT NULL,
    [PeriodClosed]     BIT         NULL,
    [DatePeriodClosed] DATE        NULL,
    [CompanyId]        INT         NOT NULL,
    [PeriodId]         INT         IDENTITY (1, 1) NOT NULL,
    PRIMARY KEY CLUSTERED ([PeriodId] ASC)
);

