CREATE TABLE [dbo].[Vacantions] (
    [Number Of People]          INT             NULL,
    [Destination]               NVARCHAR (50)   NULL,
    [Transport Type]            NVARCHAR(50)             NULL,
    [Hotel Stars]               INT             NULL,
    [Rooms]                     NVARCHAR(50)      NULL,
    [Is Room Free]              BIT             NULL,
    [Price Of Bed For Adult]    DECIMAL (18, 2) NULL,
    [Price Of Bed For Children] DECIMAL (18, 2) NULL,
    [Number]                    INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Number]),
    UNIQUE NONCLUSTERED ([Number] ASC)
);

