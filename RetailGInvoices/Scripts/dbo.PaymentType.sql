CREATE TABLE [dbo].[PaymentType] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [Type]          VARCHAR (50) NULL,
    [Description]   VARCHAR (50) NOT NULL,
    [CardIssuer]    VARCHAR (50) NULL,
    [CardNumber]    VARCHAR (50) NULL,
    [ReconcileFlag] BIT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

