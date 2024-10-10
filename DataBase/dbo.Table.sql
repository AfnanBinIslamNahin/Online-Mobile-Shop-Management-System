CREATE TABLE [dbo].[addphone]
(
	 
    [company] VARCHAR(50) NULL, 
    [model ] VARCHAR(50) NULL, 
    [ram] VARCHAR(50) NULL, 
    [internal_storage] VARCHAR(50) NULL, 
    [expandable_memory] VARCHAR(50) NULL, 
    [display] VARCHAR(50) NULL, 
    [rear_camera] VARCHAR(50) NULL, 
    [front_camera] VARCHAR(50) NULL, 
    [fingerprint_sensor] VARCHAR(50) NULL, 
    [battery] VARCHAR(50) NULL, 
	[serial_number] INT NOT NULL PRIMARY KEY IDENTITY,
    [network_type] VARCHAR(50) NULL, 
    [color_available] VARCHAR(50) NULL, 
    [price] VARCHAR(50) NULL
)
