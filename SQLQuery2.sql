USE Master
GO
DROP DATABASE Location
GO
CREATE DATABASE Location
GO
USE Location
GO


CREATE TABLE Vehicule(
  [Permis] VARCHAR(13) PRIMARY KEY,
  [Nom] VARCHAR(50),
  [Prénom] VARCHAR(50),
  [Télephone] CHAR(10),
  [Date] DATE,
  [Modele] VARCHAR(50),
  [Prix] VARCHAR(10),
  [Jour] CHAR(1)
);
GO

INSERT INTO Vehicule VALUES 
('T245564245690','Benoit','Tremblay','8191515783','2000-01-01','Honda Civic','6','1')

GO

SELECT * FROM Vehicule