CREATE TABLE [dbo].[VatRate] (
    [Id]          INT          NOT NULL,
    [Description] VARCHAR (50) NULL,
    [Rate]        MONEY        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

