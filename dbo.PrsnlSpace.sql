CREATE TABLE [dbo].[PrsnlSpace] (
    [fname]     VARCHAR (50) NULL,
    [lname]     VARCHAR (50) NULL,
    [msg]       VARCHAR (50) NULL,
    [email]     VARCHAR (50) NULL,
    [date]      DATE         NULL,
    [time]      TIME (7)     NULL,
    [id]        INT          NOT NULL,
    [spacename] VARCHAR (50) NULL,
    [spacedesc] VARCHAR (50) NULL,
    CONSTRAINT [PK_PrsnlSpace] PRIMARY KEY CLUSTERED ([id] ASC)
);

