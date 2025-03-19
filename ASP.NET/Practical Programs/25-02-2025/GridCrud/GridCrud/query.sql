CREATE TABLE [dbo].[Students] (
    [StudentID]     INT            IDENTITY (1, 1) NOT NULL,
    [StudentName]   NVARCHAR (100) NOT NULL,
    [MobileNumber]  NVARCHAR (20)  NOT NULL,
    [Gender]        NVARCHAR (10)  NOT NULL,
    PRIMARY KEY CLUSTERED ([StudentID] ASC)
);