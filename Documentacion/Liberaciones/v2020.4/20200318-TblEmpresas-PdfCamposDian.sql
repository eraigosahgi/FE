/*
   miércoles, 18 de marzo de 202015:22:35
   User: Hgi
   Server: DESAQA-PC\SQL2014
   Database: DEV_FacturacionElectronica
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.TblEmpresas ADD
	IntPdfCampoDian bit NOT NULL CONSTRAINT DF_TblEmpresas_IntPdfCampoDIAN DEFAULT 0,
	IntPdfCampoDianPosX decimal(10, 2) NOT NULL CONSTRAINT DF_TblEmpresas_IntPdfCampoDianPosX DEFAULT 0,
	IntPdfCampoDianPosY decimal(10, 2) NOT NULL CONSTRAINT DF_TblEmpresas_IntPdfCampoDianPosY DEFAULT 0
GO
ALTER TABLE dbo.TblEmpresas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TblEmpresas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TblEmpresas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TblEmpresas', 'Object', 'CONTROL') as Contr_Per 