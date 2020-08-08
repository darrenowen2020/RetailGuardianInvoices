CREATE TABLE [dbo].[Supplier] (
    [Id]                INT          IDENTITY (1, 1) NOT NULL,
    [Name]              VARCHAR (50) NOT NULL,
    [Address1]          VARCHAR (50) NULL,
    [Address2]          VARCHAR (50) NULL,
    [Address3]          VARCHAR (50) NULL,
    [Address4]          VARCHAR (50) NULL,
    [Postcode]          VARCHAR (20) NULL,
    [FK_DefaultHeading] INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

