CREATE TABLE [Card]
(
	Id INT IDENTITY(1, 1) NOT NULL,
	CardSetId INT NOT NULL,
	Layout NVARCHAR(150) NOT NULL,
	Name NVARCHAR(150) NOT NULL,
	Names NVARCHAR(350) NOT NULL,           -- array
	ManaCost NVARCHAR(150) NOT NULL,
	Cmc FLOAT NOT NULL,
	Colors NVARCHAR(150) NOT NULL,           -- array
	ColorIdentity NVARCHAR(150) NOT NULL,           -- array
	Type NVARCHAR(150) NOT NULL,
	Supertypes NVARCHAR(250) NOT NULL,           -- array
	Types NVARCHAR(250) NOT NULL,           -- array
	Subtypes NVARCHAR(250) NOT NULL,           -- array
	Rarity NVARCHAR(150) NOT NULL,
	Text NVARCHAR(150) NOT NULL,
	Flavor NVARCHAR(150) NOT NULL,
	Artist NVARCHAR(150) NOT NULL,
	Number NVARCHAR(150) NOT NULL,
	Power NVARCHAR(150) NOT NULL,
	Toughness NVARCHAR(150) NOT NULL,
	Loyalty INT NULL,
	Multiverseid INT NOT NULL,
	Variations NVARCHAR(150) NOT NULL,           -- array
	ImageName NVARCHAR(150) NOT NULL,
	Watermark NVARCHAR(150) NOT NULL,
	Border NVARCHAR(150) NOT NULL,
	Timeshifted BIT NOT NULL,
	Reserved BIT NOT NULL,
	ReleaseDate DATETIME NOT NULL

	CONSTRAINT pk_Card_Id PRIMARY KEY (Id),
	CONSTRAINT fk_Card_CardSetId FOREIGN KEY (CardSetId) REFERENCES dbo.CardSet (Id)
)