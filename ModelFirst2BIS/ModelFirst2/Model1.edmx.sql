
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/20/2021 17:15:07
-- Generated from EDMX file: C:\Users\AstataTarde\Desktop\ModelFirst2\ModelFirst2\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [modelFirst2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EMPLEADOSet'
CREATE TABLE [dbo].[EMPLEADOSet] (
    [Id_EMPLEADO] int IDENTITY(1,1) NOT NULL,
    [COD_EMPLEADO] nvarchar(max)  NOT NULL,
    [CELULA_EMPLEADO] nvarchar(max)  NOT NULL,
    [NOMBRE_EMPLEADO] nvarchar(max)  NOT NULL,
    [ID_DEPARTAMENTO] int  NOT NULL,
    [ID_PUESTO] int  NOT NULL,
    [SALARIO_MENSUAL_EMPLEADO] float  NOT NULL,
    [RESPONSABLE_AREA] nvarchar(max)  NOT NULL,
    [DEPARTAMENTO_ID_DEPARTAMENTO] int  NOT NULL,
    [PUESTO_ID_PUESTO] int  NOT NULL
);
GO

-- Creating table 'DEPARTAMENTOSet'
CREATE TABLE [dbo].[DEPARTAMENTOSet] (
    [ID_DEPARTAMENTO] int IDENTITY(1,1) NOT NULL,
    [NOMBRE_DEPARTAMENTO] nvarchar(max)  NOT NULL,
    [UBICACION_FISICA_DEPARTAMENTO] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PUESTOSet'
CREATE TABLE [dbo].[PUESTOSet] (
    [ID_PUESTO] int IDENTITY(1,1) NOT NULL,
    [NOMBRE_PUESTO] nvarchar(max)  NOT NULL,
    [ID_NIVEL_RIESGO] int  NOT NULL,
    [NIVEL_SALARIO_MIN] int  NOT NULL,
    [NIVEL_SALARIO_MAX] int  NOT NULL,
    [NIVEL_RIESGO_ID_NIVEL_RIESGO] int  NOT NULL
);
GO

-- Creating table 'NIVEL_RIESGOSet'
CREATE TABLE [dbo].[NIVEL_RIESGOSet] (
    [ID_NIVEL_RIESGO] int IDENTITY(1,1) NOT NULL,
    [TIPO_RIESGO] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'REGISTRO_TRANSACCIONSet'
CREATE TABLE [dbo].[REGISTRO_TRANSACCIONSet] (
    [ID_TRANSACCION_INGRESO] int IDENTITY(1,1) NOT NULL,
    [ID_EMPLEADO] int  NOT NULL,
    [ID_TIPO_INGRESO] int  NOT NULL,
    [FECHA] datetime  NOT NULL,
    [MONTO] float  NOT NULL,
    [EMPLEADO_Id_EMPLEADO] int  NOT NULL,
    [TIPO_DE_INGRESO_ID_TIPO_INGRESO] int  NOT NULL
);
GO

-- Creating table 'TIPO_DE_INGRESOSet'
CREATE TABLE [dbo].[TIPO_DE_INGRESOSet] (
    [ID_TIPO_INGRESO] int IDENTITY(1,1) NOT NULL,
    [NOMBRE_TIPO_INGRESO] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'REGISTRO_TRANSACCION_DEDUCCIONSet'
CREATE TABLE [dbo].[REGISTRO_TRANSACCION_DEDUCCIONSet] (
    [ID_TRANSACCION_DEDUCCION] int IDENTITY(1,1) NOT NULL,
    [ID_EMPLEADO] int  NOT NULL,
    [ID_TIPO_DEDUCCION] int  NOT NULL,
    [FECHA] datetime  NOT NULL,
    [MONTO] float  NOT NULL,
    [EMPLEADO_Id_EMPLEADO] int  NOT NULL
);
GO

-- Creating table 'TIPO_DE_DEDUCCIONSet'
CREATE TABLE [dbo].[TIPO_DE_DEDUCCIONSet] (
    [ID_TIPO_DEDUCCION] int IDENTITY(1,1) NOT NULL,
    [NOMBRE_TIPO_DEDUCCION] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_EMPLEADO] in table 'EMPLEADOSet'
ALTER TABLE [dbo].[EMPLEADOSet]
ADD CONSTRAINT [PK_EMPLEADOSet]
    PRIMARY KEY CLUSTERED ([Id_EMPLEADO] ASC);
GO

-- Creating primary key on [ID_DEPARTAMENTO] in table 'DEPARTAMENTOSet'
ALTER TABLE [dbo].[DEPARTAMENTOSet]
ADD CONSTRAINT [PK_DEPARTAMENTOSet]
    PRIMARY KEY CLUSTERED ([ID_DEPARTAMENTO] ASC);
GO

-- Creating primary key on [ID_PUESTO] in table 'PUESTOSet'
ALTER TABLE [dbo].[PUESTOSet]
ADD CONSTRAINT [PK_PUESTOSet]
    PRIMARY KEY CLUSTERED ([ID_PUESTO] ASC);
GO

-- Creating primary key on [ID_NIVEL_RIESGO] in table 'NIVEL_RIESGOSet'
ALTER TABLE [dbo].[NIVEL_RIESGOSet]
ADD CONSTRAINT [PK_NIVEL_RIESGOSet]
    PRIMARY KEY CLUSTERED ([ID_NIVEL_RIESGO] ASC);
GO

-- Creating primary key on [ID_TRANSACCION_INGRESO] in table 'REGISTRO_TRANSACCIONSet'
ALTER TABLE [dbo].[REGISTRO_TRANSACCIONSet]
ADD CONSTRAINT [PK_REGISTRO_TRANSACCIONSet]
    PRIMARY KEY CLUSTERED ([ID_TRANSACCION_INGRESO] ASC);
GO

-- Creating primary key on [ID_TIPO_INGRESO] in table 'TIPO_DE_INGRESOSet'
ALTER TABLE [dbo].[TIPO_DE_INGRESOSet]
ADD CONSTRAINT [PK_TIPO_DE_INGRESOSet]
    PRIMARY KEY CLUSTERED ([ID_TIPO_INGRESO] ASC);
GO

-- Creating primary key on [ID_TRANSACCION_DEDUCCION] in table 'REGISTRO_TRANSACCION_DEDUCCIONSet'
ALTER TABLE [dbo].[REGISTRO_TRANSACCION_DEDUCCIONSet]
ADD CONSTRAINT [PK_REGISTRO_TRANSACCION_DEDUCCIONSet]
    PRIMARY KEY CLUSTERED ([ID_TRANSACCION_DEDUCCION] ASC);
GO

-- Creating primary key on [ID_TIPO_DEDUCCION] in table 'TIPO_DE_DEDUCCIONSet'
ALTER TABLE [dbo].[TIPO_DE_DEDUCCIONSet]
ADD CONSTRAINT [PK_TIPO_DE_DEDUCCIONSet]
    PRIMARY KEY CLUSTERED ([ID_TIPO_DEDUCCION] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DEPARTAMENTO_ID_DEPARTAMENTO] in table 'EMPLEADOSet'
ALTER TABLE [dbo].[EMPLEADOSet]
ADD CONSTRAINT [FK_DEPARTAMENTOEMPLEADO]
    FOREIGN KEY ([DEPARTAMENTO_ID_DEPARTAMENTO])
    REFERENCES [dbo].[DEPARTAMENTOSet]
        ([ID_DEPARTAMENTO])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DEPARTAMENTOEMPLEADO'
CREATE INDEX [IX_FK_DEPARTAMENTOEMPLEADO]
ON [dbo].[EMPLEADOSet]
    ([DEPARTAMENTO_ID_DEPARTAMENTO]);
GO

-- Creating foreign key on [PUESTO_ID_PUESTO] in table 'EMPLEADOSet'
ALTER TABLE [dbo].[EMPLEADOSet]
ADD CONSTRAINT [FK_PUESTOEMPLEADO]
    FOREIGN KEY ([PUESTO_ID_PUESTO])
    REFERENCES [dbo].[PUESTOSet]
        ([ID_PUESTO])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PUESTOEMPLEADO'
CREATE INDEX [IX_FK_PUESTOEMPLEADO]
ON [dbo].[EMPLEADOSet]
    ([PUESTO_ID_PUESTO]);
GO

-- Creating foreign key on [NIVEL_RIESGO_ID_NIVEL_RIESGO] in table 'PUESTOSet'
ALTER TABLE [dbo].[PUESTOSet]
ADD CONSTRAINT [FK_NIVEL_RIESGOPUESTO]
    FOREIGN KEY ([NIVEL_RIESGO_ID_NIVEL_RIESGO])
    REFERENCES [dbo].[NIVEL_RIESGOSet]
        ([ID_NIVEL_RIESGO])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NIVEL_RIESGOPUESTO'
CREATE INDEX [IX_FK_NIVEL_RIESGOPUESTO]
ON [dbo].[PUESTOSet]
    ([NIVEL_RIESGO_ID_NIVEL_RIESGO]);
GO

-- Creating foreign key on [EMPLEADO_Id_EMPLEADO] in table 'REGISTRO_TRANSACCIONSet'
ALTER TABLE [dbo].[REGISTRO_TRANSACCIONSet]
ADD CONSTRAINT [FK_EMPLEADOREGISTRO_TRANSACCION]
    FOREIGN KEY ([EMPLEADO_Id_EMPLEADO])
    REFERENCES [dbo].[EMPLEADOSet]
        ([Id_EMPLEADO])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EMPLEADOREGISTRO_TRANSACCION'
CREATE INDEX [IX_FK_EMPLEADOREGISTRO_TRANSACCION]
ON [dbo].[REGISTRO_TRANSACCIONSet]
    ([EMPLEADO_Id_EMPLEADO]);
GO

-- Creating foreign key on [TIPO_DE_INGRESO_ID_TIPO_INGRESO] in table 'REGISTRO_TRANSACCIONSet'
ALTER TABLE [dbo].[REGISTRO_TRANSACCIONSet]
ADD CONSTRAINT [FK_TIPO_DE_INGRESOREGISTRO_TRANSACCION]
    FOREIGN KEY ([TIPO_DE_INGRESO_ID_TIPO_INGRESO])
    REFERENCES [dbo].[TIPO_DE_INGRESOSet]
        ([ID_TIPO_INGRESO])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TIPO_DE_INGRESOREGISTRO_TRANSACCION'
CREATE INDEX [IX_FK_TIPO_DE_INGRESOREGISTRO_TRANSACCION]
ON [dbo].[REGISTRO_TRANSACCIONSet]
    ([TIPO_DE_INGRESO_ID_TIPO_INGRESO]);
GO

-- Creating foreign key on [EMPLEADO_Id_EMPLEADO] in table 'REGISTRO_TRANSACCION_DEDUCCIONSet'
ALTER TABLE [dbo].[REGISTRO_TRANSACCION_DEDUCCIONSet]
ADD CONSTRAINT [FK_EMPLEADOREGISTRO_TRANSACCION_DEDUCCION]
    FOREIGN KEY ([EMPLEADO_Id_EMPLEADO])
    REFERENCES [dbo].[EMPLEADOSet]
        ([Id_EMPLEADO])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EMPLEADOREGISTRO_TRANSACCION_DEDUCCION'
CREATE INDEX [IX_FK_EMPLEADOREGISTRO_TRANSACCION_DEDUCCION]
ON [dbo].[REGISTRO_TRANSACCION_DEDUCCIONSet]
    ([EMPLEADO_Id_EMPLEADO]);
GO

-- Creating foreign key on [ID_TIPO_DEDUCCION] in table 'REGISTRO_TRANSACCION_DEDUCCIONSet'
ALTER TABLE [dbo].[REGISTRO_TRANSACCION_DEDUCCIONSet]
ADD CONSTRAINT [FK_TIPO_DE_DEDUCCIONREGISTRO_TRANSACCION_DEDUCCION]
    FOREIGN KEY ([ID_TIPO_DEDUCCION])
    REFERENCES [dbo].[TIPO_DE_DEDUCCIONSet]
        ([ID_TIPO_DEDUCCION])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TIPO_DE_DEDUCCIONREGISTRO_TRANSACCION_DEDUCCION'
CREATE INDEX [IX_FK_TIPO_DE_DEDUCCIONREGISTRO_TRANSACCION_DEDUCCION]
ON [dbo].[REGISTRO_TRANSACCION_DEDUCCIONSet]
    ([ID_TIPO_DEDUCCION]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------