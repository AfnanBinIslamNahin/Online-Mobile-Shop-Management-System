CREATE TABLE [dbo].[users] (
    [f_name]   VARCHAR (50) NULL,
    [l_name]   VARCHAR (50) NULL,
    [date]     VARCHAR (50) NULL,
    [gender]   VARCHAR (50) NULL,
    [address]  VARCHAR (50) NULL,
    [email]    VARCHAR (50) NOT NULL,
    [password] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([email] ASC)
);

