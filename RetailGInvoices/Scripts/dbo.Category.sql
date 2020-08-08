CREATE TABLE [dbo].[Category] (
    [Id]           INT          NOT NULL,
    [Description]  VARCHAR (50) NOT NULL,
    [FK_VatRateID] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_VatRateID] FOREIGN KEY ([FK_VatRateID]) REFERENCES [dbo].[VatRate] ([Id])
);

