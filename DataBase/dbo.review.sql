CREATE TABLE [dbo].[review] (
    [review_id]      INT          NOT NULL,
    [customer_email] VARCHAR (50) NULL,
    [message]        VARCHAR (50) NULL,
    [company]        VARCHAR (50) NULL,
    [model]          VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([review_id] ASC), 
    CONSTRAINT [FK_review_ToTable] FOREIGN KEY ([customer_email]) REFERENCES [users]([email])
);

