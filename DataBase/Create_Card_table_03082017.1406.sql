CREATE TABLE [Card]
(
	Id uniqueidentifier NOT NULL,
	MtgJsonId NVARCHAR(40) NOT NULL,
	CardSetId uniqueidentifier NOT NULL,
	Layout NVARCHAR(150) NULL,
	Name NVARCHAR(150) NOT NULL,
	Names NVARCHAR(350) NULL,           -- array
	ManaCost NVARCHAR(150) NULL,
	Cmc FLOAT NULL,
	Colors NVARCHAR(150) NULL,           -- array
	ColorIdentity NVARCHAR(150) NULL,           -- array
	Type NVARCHAR(150) NULL,
	Supertypes NVARCHAR(250) NULL,           -- array
	Types NVARCHAR(250) NULL,           -- array
	Subtypes NVARCHAR(250) NULL,           -- array
	Rarity NVARCHAR(150) NULL,
	Text NVARCHAR(MAX) NULL,
	Flavor NVARCHAR(MAX) NULL,
	Artist NVARCHAR(150) NULL,
	Number NVARCHAR(150) NULL,
	Power NVARCHAR(150) NULL,
	Toughness NVARCHAR(150) NULL,
	Loyalty INT NULL,
	Multiverseid INT NOT NULL,
	Variations NVARCHAR(150) NULL,           -- array
	ImageName NVARCHAR(150) NOT NULL,
	Watermark NVARCHAR(150) NULL,
	Border NVARCHAR(150) NULL,
	Timeshifted BIT NULL,
	Reserved BIT NULL,
	ReleaseDate NVARCHAR(150) NULL

	CONSTRAINT pk_Card_Id PRIMARY KEY (Id),
	CONSTRAINT fk_Card_CardSetId FOREIGN KEY (CardSetId) REFERENCES dbo.CardSet (Id)
)
--DROP TABLE CARD