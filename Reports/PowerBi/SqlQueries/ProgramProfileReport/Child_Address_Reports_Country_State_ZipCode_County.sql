---------------------------------------------------------------------
--Used for Child Address reports Report -- Country State ZipCode County OtherGeographichInfo
---------------------------------------------------------------------

--use [pchp-dev];
SELECT 
	Child.Id as ChildId, Child.FirstName, Child.LastName,
	Addresses.Id AS AddressId, AddressType, IsPrimaryAddress, 
	CountryId, Countries.FullName AS CountryName, 
	State, AddressLine1, AddressLine2, AddressLine3, 
	City, PostalCode, County, OtherGeographichInfo

FROM Child 
	LEFT JOIN Addresses ON Addresses.ChildId = Child.Id
	LEFT JOIN Countries ON Countries.Id = Addresses.CountryId

Where ChildId IS NOT NULL AND Addresses.IsActive=1 AND Child.IsDeleted = 0

