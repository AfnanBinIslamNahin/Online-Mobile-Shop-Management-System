CREATE TABLE [dbo].[mobile_service] (
    [service_Id] INT          NOT NULL,
    [brand]      VARCHAR (50) NULL,
    [model]      VARCHAR (50) NULL,
    [issue]      VARCHAR (50) NULL,
    [picture]    IMAGE        NULL,
    [email]      VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([service_Id] ASC), 
    CONSTRAINT [FK_mobile_service_ToTable] FOREIGN KEY ([email]) REFERENCES [users]([email])
);

