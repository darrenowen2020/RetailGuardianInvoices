CREATE TABLE [dbo].[Site] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [SiteName]     VARCHAR (50) NULL,
    [Address1]     VARCHAR (50) NULL,
    [Address2]     VARCHAR (50) NULL,
    [Address3]     VARCHAR (50) NULL,
    [Address4]     VARCHAR (50) NULL,
    [PostCode]     VARCHAR (50) NULL,
    [FK_CompanyId] INT          NULL,
    [VATCode]      VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Company] FOREIGN KEY ([FK_CompanyId]) REFERENCES [dbo].[Company] ([Id])
);

