CREATE TABLE [dbo].[service_center] (
    [technician_Id] INT          NOT NULL,
    [service_id]    VARCHAR (50) NULL,
    [solution]      VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([technician_Id] ASC)
);

