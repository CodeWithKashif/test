
SELECT 
	Child.Id as ChildId, Child.FirstName, Child.LastName,
	IsPrimaryCaregiver, 
	
	Ethinicity.Id AS EthinicityId, Ethinicity.Name AS EthinicityName,
	ChildAdultInformation.SubEthinicityId, SubEthinicity.Name AS SubEthinicityName,
	ChildAdultInformation.DateOfBirth,
	MaritalStatus, MaritalStatusMasterData.Value AS MaritalStatusValue,
	RelationshipToChild, RelationshipToChildMasterData.Value AS RelationshipToChildValue,
	IsSingleParent, WasThisAdult19YearsOldWhenThisChildWasBorn AS IsTeenParent,
	
	CanSpeakEnglish, CanSpeakEnglishData.Value As CanSpeakEnglishValue,
	CanWriteEnglish, CanWriteEnglishData.Value AS CanWriteEnglishValue,
	CanWriteNativeLanguage, CanWriteNativeLanguageData.Value As CanWriteNativeLanguageValue,
	
	HasAdultGraduatedHighSchoolOrReceiveGed,
	NumberOfYearsSchoolingCompletedInsideUs AS LevelOfSchoolingCompletedInUS,
	LevelOfSchoolingCompletedInUSMasterData.Value AS LevelOfSchoolingCompletedInUSValue,
	
	NumberOfYearsSchoolingCompletedOutsideUs AS LevelOfSchoolingCompletedOutsideUS,
	LevelOfSchoolingCompletedOutsideUSMasterData.Value AS LevelOfSchoolingCompletedOutsideUSValue,

	IsAdultCurrentlyInSchoolOrEducationalProgram, 
	SchoolOrEducationalProgramType AS CurrentlyInSchoolOrEducationalProgram,
	CurrentlyInSchoolOrEducationalProgramMasterData.value AS CurrentlyInSchoolOrEducationalProgramValue,

	EmploymentStatusId,EmploymentStatus.Name As EmploymentStatusName

FROM Child 
	LEFT JOIN ChildAdultInformation ON ChildAdultInformation.ChildId = Child.Id
	LEFT JOIN SubEthinicity ON SubEthinicity.Id = ChildAdultInformation.SubEthinicityId
	LEFT JOIN Ethinicity ON Ethinicity.Id = SubEthinicity.EthinicityId
	LEFT JOIN DropdownMasterData RelationshipToChildMasterData ON RelationshipToChildMasterData.Id = ChildAdultInformation.RelationshipToChild
	LEFT JOIN DropdownMasterData MaritalStatusMasterData ON MaritalStatusMasterData.Id = ChildAdultInformation.MaritalStatus

	LEFT JOIN DropdownMasterData CanSpeakEnglishData ON CanSpeakEnglishData.Id = ChildAdultInformation.CanSpeakEnglish
	LEFT JOIN DropdownMasterData CanWriteEnglishData ON CanWriteEnglishData.Id = ChildAdultInformation.CanWriteEnglish
	LEFT JOIN DropdownMasterData CanWriteNativeLanguageData ON CanWriteNativeLanguageData.Id = ChildAdultInformation.CanWriteNativeLanguage
	
	LEFT JOIN DropdownMasterData LevelOfSchoolingCompletedInUSMasterData ON LevelOfSchoolingCompletedInUSMasterData.Id = ChildAdultInformation.NumberOfYearsSchoolingCompletedInsideUs
	LEFT JOIN DropdownMasterData LevelOfSchoolingCompletedOutsideUSMasterData ON LevelOfSchoolingCompletedOutsideUSMasterData.Id = ChildAdultInformation.NumberOfYearsSchoolingCompletedOutsideUs
	
	LEFT JOIN DropdownMasterData CurrentlyInSchoolOrEducationalProgramMasterData ON CurrentlyInSchoolOrEducationalProgramMasterData.Id = ChildAdultInformation.SchoolOrEducationalProgramType

	LEFT JOIN EmploymentStatus ON EmploymentStatus.Id = ChildAdultInformation.EmploymentStatusId

	order by Child.Id


