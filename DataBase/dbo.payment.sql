CREATE TABLE [dbo].[payment] (
    [payment_Id]     INT          NOT NULL,
    [customer_email] VARCHAR (50) NULL,
    [payment_date]   VARCHAR (50) NULL,
    [payment_method] VARCHAR (50) NULL,
    [address]        VARCHAR (50) NULL,
    [company]        VARCHAR (50) NULL,
    [model]          VARCHAR (50) NULL,
    [price]          VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([payment_Id] ASC), 
    CONSTRAINT [FK_payment_ToTable] FOREIGN KEY ([customer_email]) REFERENCES [users]([email])
);

