
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/24/2015 13:22:47
-- Generated from EDMX file: C:\Users\Peter\Documents\GitHub\ResehanteringsSystem\vITs\DAL\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Bosses_ToUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bosses] DROP CONSTRAINT [FK_Bosses_ToUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_Trips_ToBoss]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Trips] DROP CONSTRAINT [FK_Trips_ToBoss];
GO
IF OBJECT_ID(N'[dbo].[FK_Trips_ToCountry]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Trips] DROP CONSTRAINT [FK_Trips_ToCountry];
GO
IF OBJECT_ID(N'[dbo].[FK_Trips_ToCountry2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Trips] DROP CONSTRAINT [FK_Trips_ToCountry2];
GO
IF OBJECT_ID(N'[dbo].[FK_Trips_ToUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Trips] DROP CONSTRAINT [FK_Trips_ToUser];
GO
IF OBJECT_ID(N'[dbo].[FK_Vacations_ToTrip]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vacations] DROP CONSTRAINT [FK_Vacations_ToTrip];
GO
IF OBJECT_ID(N'[dbo].[FK_Verifications_Expences]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Verifications] DROP CONSTRAINT [FK_Verifications_Expences];
GO
IF OBJECT_ID(N'[dbo].[FK_Verifications_Trips]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Verifications] DROP CONSTRAINT [FK_Verifications_Trips];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Bosses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bosses];
GO
IF OBJECT_ID(N'[dbo].[Countries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Countries];
GO
IF OBJECT_ID(N'[dbo].[Expences]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Expences];
GO
IF OBJECT_ID(N'[dbo].[Settings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Settings];
GO
IF OBJECT_ID(N'[dbo].[Trips]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Trips];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Vacations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vacations];
GO
IF OBJECT_ID(N'[dbo].[Verifications]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Verifications];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Bosses'
CREATE TABLE [dbo].[Bosses] (
    [userID] int  NOT NULL
);
GO

-- Creating table 'Countries'
CREATE TABLE [dbo].[Countries] (
    [countryID] int IDENTITY(1,1) NOT NULL,
    [country1] varchar(50)  NOT NULL,
    [allowance] int  NOT NULL
);
GO

-- Creating table 'Expences'
CREATE TABLE [dbo].[Expences] (
    [expenceID] int IDENTITY(1,1) NOT NULL,
    [type] varchar(30)  NOT NULL
);
GO

-- Creating table 'Settings'
CREATE TABLE [dbo].[Settings] (
    [settingID] int IDENTITY(1,1) NOT NULL,
    [name] varchar(50)  NOT NULL,
    [value] float  NOT NULL,
    [note] varchar(max)  NOT NULL
);
GO

-- Creating table 'Trips'
CREATE TABLE [dbo].[Trips] (
    [tripID] int IDENTITY(1,1) NOT NULL,
    [origin] int  NOT NULL,
    [destination] int  NOT NULL,
    [start] datetime  NOT NULL,
    [end] datetime  NOT NULL,
    [prepayment] int  NULL,
    [note] varchar(max)  NULL,
    [user] int  NOT NULL,
    [boss] int  NOT NULL,
    [approved] int  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [userID] int IDENTITY(1,1) NOT NULL,
    [firstname] varchar(25)  NOT NULL,
    [lastname] varchar(25)  NOT NULL,
    [password] varchar(30)  NOT NULL,
    [email] varchar(50)  NOT NULL,
    [phone] varchar(50)  NULL,
    [boss] int  NULL
);
GO

-- Creating table 'Vacations'
CREATE TABLE [dbo].[Vacations] (
    [VacationID] int IDENTITY(1,1) NOT NULL,
    [start] datetime  NOT NULL,
    [end] datetime  NOT NULL,
    [tripID] int  NOT NULL
);
GO

-- Creating table 'Verifications'
CREATE TABLE [dbo].[Verifications] (
    [verificationID] int IDENTITY(1,1) NOT NULL,
    [expenceID] int  NOT NULL,
    [cost] float  NOT NULL,
    [path] varchar(max)  NULL,
    [date] datetime  NOT NULL,
    [note] varchar(max)  NULL,
    [tripID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [userID] in table 'Bosses'
ALTER TABLE [dbo].[Bosses]
ADD CONSTRAINT [PK_Bosses]
    PRIMARY KEY CLUSTERED ([userID] ASC);
GO

-- Creating primary key on [countryID] in table 'Countries'
ALTER TABLE [dbo].[Countries]
ADD CONSTRAINT [PK_Countries]
    PRIMARY KEY CLUSTERED ([countryID] ASC);
GO

-- Creating primary key on [expenceID] in table 'Expences'
ALTER TABLE [dbo].[Expences]
ADD CONSTRAINT [PK_Expences]
    PRIMARY KEY CLUSTERED ([expenceID] ASC);
GO

-- Creating primary key on [settingID] in table 'Settings'
ALTER TABLE [dbo].[Settings]
ADD CONSTRAINT [PK_Settings]
    PRIMARY KEY CLUSTERED ([settingID] ASC);
GO

-- Creating primary key on [tripID] in table 'Trips'
ALTER TABLE [dbo].[Trips]
ADD CONSTRAINT [PK_Trips]
    PRIMARY KEY CLUSTERED ([tripID] ASC);
GO

-- Creating primary key on [userID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([userID] ASC);
GO

-- Creating primary key on [VacationID] in table 'Vacations'
ALTER TABLE [dbo].[Vacations]
ADD CONSTRAINT [PK_Vacations]
    PRIMARY KEY CLUSTERED ([VacationID] ASC);
GO

-- Creating primary key on [verificationID] in table 'Verifications'
ALTER TABLE [dbo].[Verifications]
ADD CONSTRAINT [PK_Verifications]
    PRIMARY KEY CLUSTERED ([verificationID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [userID] in table 'Bosses'
ALTER TABLE [dbo].[Bosses]
ADD CONSTRAINT [FK_Bosses_ToUsers]
    FOREIGN KEY ([userID])
    REFERENCES [dbo].[Users]
        ([userID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [origin] in table 'Trips'
ALTER TABLE [dbo].[Trips]
ADD CONSTRAINT [FK_Trips_ToCountry]
    FOREIGN KEY ([origin])
    REFERENCES [dbo].[Countries]
        ([countryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Trips_ToCountry'
CREATE INDEX [IX_FK_Trips_ToCountry]
ON [dbo].[Trips]
    ([origin]);
GO

-- Creating foreign key on [destination] in table 'Trips'
ALTER TABLE [dbo].[Trips]
ADD CONSTRAINT [FK_Trips_ToCountry2]
    FOREIGN KEY ([destination])
    REFERENCES [dbo].[Countries]
        ([countryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Trips_ToCountry2'
CREATE INDEX [IX_FK_Trips_ToCountry2]
ON [dbo].[Trips]
    ([destination]);
GO

-- Creating foreign key on [expenceID] in table 'Verifications'
ALTER TABLE [dbo].[Verifications]
ADD CONSTRAINT [FK_Verifications_Expences]
    FOREIGN KEY ([expenceID])
    REFERENCES [dbo].[Expences]
        ([expenceID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Verifications_Expences'
CREATE INDEX [IX_FK_Verifications_Expences]
ON [dbo].[Verifications]
    ([expenceID]);
GO

-- Creating foreign key on [user] in table 'Trips'
ALTER TABLE [dbo].[Trips]
ADD CONSTRAINT [FK_Trips_ToUser]
    FOREIGN KEY ([user])
    REFERENCES [dbo].[Users]
        ([userID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Trips_ToUser'
CREATE INDEX [IX_FK_Trips_ToUser]
ON [dbo].[Trips]
    ([user]);
GO

-- Creating foreign key on [tripID] in table 'Vacations'
ALTER TABLE [dbo].[Vacations]
ADD CONSTRAINT [FK_Vacations_ToTrip]
    FOREIGN KEY ([tripID])
    REFERENCES [dbo].[Trips]
        ([tripID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Vacations_ToTrip'
CREATE INDEX [IX_FK_Vacations_ToTrip]
ON [dbo].[Vacations]
    ([tripID]);
GO

-- Creating foreign key on [tripID] in table 'Verifications'
ALTER TABLE [dbo].[Verifications]
ADD CONSTRAINT [FK_Verifications_Trips]
    FOREIGN KEY ([tripID])
    REFERENCES [dbo].[Trips]
        ([tripID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Verifications_Trips'
CREATE INDEX [IX_FK_Verifications_Trips]
ON [dbo].[Verifications]
    ([tripID]);
GO

-- Creating foreign key on [boss] in table 'Trips'
ALTER TABLE [dbo].[Trips]
ADD CONSTRAINT [FK_Trips_ToBoss]
    FOREIGN KEY ([boss])
    REFERENCES [dbo].[Bosses]
        ([userID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Trips_ToBoss'
CREATE INDEX [IX_FK_Trips_ToBoss]
ON [dbo].[Trips]
    ([boss]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------