


----------------SiteCoordinator
select * from StaffDemographics where EducationLevel is not  null
select * from DropdownMasterData where type ='Education'
update StaffDemographics set EducationLevel=44 where id>1 and id<100
update StaffDemographics set EducationLevel=47 where id>101 and id<200
update StaffDemographics set EducationLevel=51 where id>201 and id<400
update StaffDemographics set EducationLevel=52 where id>401 and id<600





----------------SiteCoordinator
select * from StaffDemographics where PriorExperience is not  null
select * from DropdownMasterData where type ='SiteCoordinatorPriorExperience'
update StaffDemographics set PriorExperience=313 where id>1 and id<100
update StaffDemographics set PriorExperience=314 where id>101 and id<200
update StaffDemographics set PriorExperience=316 where id>201 and id<400



---------------HomeVisitor
select * from StaffDemographics where EducationLevel is not  null
select * from DropdownMasterData where type ='Education'
update StaffDemographics set EducationLevel=43 
update StaffDemographics set EducationLevel=45 where id>1017
update StaffDemographics set EducationLevel=51 where id>2000
update StaffDemographics set EducationLevel=52 where id>3000


---------------HomeVisitor
select * from StaffDemographics where priorexperience is  null
select * from DropdownMasterData where type ='HomeVisitorPriorExperience' 
update StaffDemographics set PriorExperience=71 where id>1017
update StaffDemographics set PriorExperience=72 where id>2000
update StaffDemographics set PriorExperience=75 where id>3000
update StaffDemographics set PriorExperience=70 where id>4000



--ChildAdditionalInformation

select * from ChildAdditionalInformation
select * from DropdownMasterData where type ='ProviderAnnualIncome'
update ChildAdditionalInformation set AnnualFamilyIncomeRange=466 
update ChildAdditionalInformation set AnnualFamilyIncomeRange=467 where id>1030
update ChildAdditionalInformation set AnnualFamilyIncomeRange=476 where id>2061
update ChildAdditionalInformation set AnnualFamilyIncomeRange=475 where id>3080


select * from ChildAdditionalInformation
select * from DropdownMasterData where type ='ReferralSources'
update ChildAdditionalInformation set HowFamilyProgramLearning=260 
update ChildAdditionalInformation set HowFamilyProgramLearning=268 where id>1030
update ChildAdditionalInformation set HowFamilyProgramLearning=264 where id>2061
update ChildAdditionalInformation set HowFamilyProgramLearning=265 where id>3080

---==============================================================================
select * from ChildAdultInformation
select * from DropdownMasterData where type ='ParentLanguageSkillLevel'
update ChildAdultInformation set CanSpeakEnglish=197 
update ChildAdultInformation set CanSpeakEnglish=198 where id>1023
update ChildAdultInformation set CanSpeakEnglish=199 where id>3057

--CanWriteEnglish 
update ChildAdultInformation set CanWriteEnglish=197 
update ChildAdultInformation set CanWriteEnglish=198 where id>1023
update ChildAdultInformation set CanWriteEnglish=199 where id>3057

--CanWriteNativeLanguage
update ChildAdultInformation set CanWriteNativeLanguage=197 
update ChildAdultInformation set CanWriteNativeLanguage=198 where id>1023
update ChildAdultInformation set CanWriteNativeLanguage=199 where id>3057

--------------------------------------------------------------
select * from ChildAdultInformation
select * from DropdownMasterData where type ='CurrentlyinSchool'
update ChildAdultInformation set SchoolOrEducationalProgramType=23 
update ChildAdultInformation set SchoolOrEducationalProgramType=24 where id>1023
update ChildAdultInformation set SchoolOrEducationalProgramType=26 where id>3057

-------------------------------------
	select * from ChildAdultInformation
select * from DropdownMasterData where type ='Education'
update ChildAdultInformation set NumberOfYearsSchoolingCompletedOutsideUs=43 
update ChildAdultInformation set NumberOfYearsSchoolingCompletedOutsideUs=44 where id>1023
update ChildAdultInformation set NumberOfYearsSchoolingCompletedOutsideUs=46 where id>3057

---------------------------------------------------------------
select * from ChildAdultInformation
select * from DropdownMasterData where type ='Education'
update ChildAdultInformation set NumberOfYearsSchoolingCompletedInsideUs=43 
update ChildAdultInformation set NumberOfYearsSchoolingCompletedInsideUs=47 where id>1023
update ChildAdultInformation set NumberOfYearsSchoolingCompletedInsideUs=51 where id>3057


--ParentChildRelation  --RelationshipToChild
select * from ChildAdultInformation
select * from DropdownMasterData where type ='ParentChildRelation'
update ChildAdultInformation set RelationshipToChild=178 
update ChildAdultInformation set RelationshipToChild=182 where id>1023
update ChildAdultInformation set RelationshipToChild=181 where id>3057

---------------
select * from ChildAdultInformation
select * from DropdownMasterData where type ='MaritalStatus'
update ChildAdultInformation set MaritalStatus=156 
update ChildAdultInformation set MaritalStatus=157 where id>1023
update ChildAdultInformation set MaritalStatus=159 where id>3057
