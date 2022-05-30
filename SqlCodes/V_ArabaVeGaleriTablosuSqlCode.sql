USE [GaleriDB]
GO

/****** Object:  View [dbo].[V_ArabaVeGaleriTablosu]    Script Date: 30.05.2022 15:59:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[V_ArabaVeGaleriTablosu]
as
select a.Id, a.Status, a.Ad, a.Ucret, a.Stok, a.Birim,a.DosyaYolu, a.GaleriId, g.Ad as [GaleriAd], g.Adres as [GaleriAdres] from Arabalar as a join Galeriler as g on a.GaleriId = g.Id
GO


