---------------------------------------------------------------------
--Used for FamilyIncomeDstribution Report - AnnualFamilyIncomeRange, 
--Used for Family is HomeLess Report -- IsFamilyHomeless, 
--Used for ReferralResources Report- ReferralResources
-----------------------------------------------------------------------
--Income_Homeless_Referral
--use [pchp-dev];
SELECT 
	Child.Id as ChildId, Child.FirstName, Child.LastName,
	
	AnnualFamilyIncomeRange, AnnualFamilyIncomeRangeMasterData.Value AnnualFamilyIncomeRangeValue, 
	
	HowFamilyProgramLearning as ReferralResource, HowFamilyProgramLearningMasterData.Value ReferralResourceValue,
	
	IsFamilyHomeless

FROM Child 
	LEFT JOIN ChildAdditionalInformation ON ChildAdditionalInformation.ChildId = Child.Id
	LEFT JOIN DropdownMasterData AS AnnualFamilyIncomeRangeMasterData ON AnnualFamilyIncomeRangeMasterData.Id = ChildAdditionalInformation.AnnualFamilyIncomeRange
	LEFT JOIN DropdownMasterData AS HowFamilyProgramLearningMasterData ON HowFamilyProgramLearningMasterData.Id = ChildAdditionalInformation.HowFamilyProgramLearning
			--AND [Type]='ProviderAnnualIncome'

