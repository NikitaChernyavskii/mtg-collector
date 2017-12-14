CREATE TABLE dbo.CardSet 
(
	Id uniqueidentifier NOT NULL,
	[Name] NVARCHAR(150) NOT NULL,
	Code NVARCHAR(150) NULL,
	GathererCode NVARCHAR(150) NULL,
	OldCode NVARCHAR(150) NULL,
	MagicCardsInfoCode NVARCHAR(150) NULL,
	ReleaseDate NVARCHAR(150) NULL,
	Border NVARCHAR(150) NULL,
	[Type] NVARCHAR(150) NULL,
	[Block] NVARCHAR(150) NULL,
	OnlineOnly BIT NOT NULL DEFAULT 0,
	--may be image
	--may be description
	
	CONSTRAINT pk_CardSet_Id PRIMARY KEY(Id),
	CONSTRAINT UC_CardSet_Name UNIQUE (Name)
)