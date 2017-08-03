CREATE TABLE CardSet 
(
	Id INT IDENTITY(1, 1) NOT NULL,
	Name NVARCHAR(150) NOT NULL,
	--may be image
	--may be description
	
	CONSTRAINT pk_CardSet_Id PRIMARY KEY(Id),
	CONSTRAINT UC_CardSet_Name UNIQUE (Name)
)