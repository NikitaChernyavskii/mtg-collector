CREATE TABLE dbo.CardRarity
(
	Id INT NOT NULL,
	Name NVARCHAR(150) NOT NULL,

	Constraint pk_CardRarity_Id PRIMARY KEY (Id),
	CONSTRAINT unique_CardRarity_Name UNIQUE (Name)
)
GO

INSERT INTO dbo.CardRarity(Id, Name)
	VALUES (1, 'Common'),
		   (2, 'Uncommon'),
		   (3, 'Rare'),
		   (4, 'Mythic Rare')