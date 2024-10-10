CREATE TABLE [dbo].[admin] (
    [full_name] VARCHAR (50) NULL,
    [address]   VARCHAR (50) NULL,
    [gender]    VARCHAR (50) NULL,
    [email]     VARCHAR (50) NOT NULL,
    [password]  VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([email] ASC)
);

