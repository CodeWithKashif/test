SELECT
	Users.Id, Users.FirstName, Users.LastName,   
	
	Ethinicity.Id AS EthinicityId, Ethinicity.Name AS EthinicityName,
	StaffDemographics.SubEthinicityId, SubEthinicity.Name AS SubEthinicityName,
	
	StaffDemographics.LanguageId NativeLanguageId, NativeLanguage.Name AS NativeLanguageName,
	
	IsRaisedInServingCommunity,
	
	PriorExperience, PriorExperienceMasterData.value AS PriorExperienceValue,

	EducationLevel, EducationLevelMasterData.value AS EducationLevelValue,

	Users.Gender
	
FROM Users
	INNER JOIN UserRoleBridge ON UserRoleBridge.UserId = Users.Id AND RoleId=14
	LEFT JOIN StaffDemographics ON StaffDemographics.UserId = Users.Id 
	LEFT JOIN SubEthinicity ON SubEthinicity.Id = StaffDemographics.SubEthinicityId
	LEFT JOIN Ethinicity ON Ethinicity.Id = SubEthinicity.EthinicityId
	LEFT JOIN Languages as NativeLanguage on NativeLanguage.Id = StaffDemographics.LanguageId
	LEFT JOIN DropdownMasterData EducationLevelMasterData ON EducationLevelMasterData.Id = StaffDemographics.EducationLevel
	LEFT JOIN DropdownMasterData PriorExperienceMasterData ON PriorExperienceMasterData.Id = StaffDemographics.PriorExperience

