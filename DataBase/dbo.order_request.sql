CREATE TABLE [dbo].[order_request] (
    [order_Id]          INT          NOT NULL,
    [brand]             VARCHAR (50) NULL,
    [model]             VARCHAR (50) NULL,
    [ram]               VARCHAR (50) NULL,
    [internal_storage]  VARCHAR (50) NULL,
    [color]             VARCHAR (50) NULL,
    [expandable_memory] VARCHAR (50) NULL,
    [email]             VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([order_Id] ASC), 
    CONSTRAINT [FK_order_request_ToTable] FOREIGN KEY ([email]) REFERENCES [users]([email])
);

