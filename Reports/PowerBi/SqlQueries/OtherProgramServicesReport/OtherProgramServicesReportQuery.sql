with Questions as
(
   select 1 as QuestionType
 union select 2 
 union select 3 
 union select 4 
 union select 5 
 union select 6 
-- union select 7
)
,ChildAndQuestions as
(
SELECT 
 Child.Id as ChildId, FirstName, LastName,
 [Site].Id AS SiteId, [Site].Name as SiteName,
 ProgramYear.ProgramYearName,ChildProgramYearBridge.ProgramCycle,
 HowFamilyProgramLearningMaster.Value HowFamilyProgramLearningMasterValue,

 Questions.QuestionType 

FROM Questions,Child
INNER JOIN [Site] ON Child.SiteId =[Site].Id AND ISNULL([Site].IsActive, 0)= 1 AND ISNULL([Site].IsDeleted, 0)= 0                                    
INNER JOIN ChildProgramYearBridge ON ChildProgramYearBridge.ChildId = Child.Id  AND ISNULL(Child.IsDeleted, 0)= 0
INNER JOIN ProgramYear ON ChildProgramYearBridge.ProgramYearId = ProgramYear.Id
			AND ISNULL(ProgramYear.IsActive, 0)= 1 and ISNULL(ProgramYear.IsDeleted, 0)= 0

LEFT JOIN ChildAdditionalInformation ON ChildAdditionalInformation.ChildId = Child.Id
LEFT JOIN DropdownMasterData HowFamilyProgramLearningMaster ON HowFamilyProgramLearningMaster.Id = ChildAdditionalInformation.HowFamilyProgramLearning

)
select ChildAndQuestions.* ,
ChildDemographicDetail.Answer,
AnswerMaster.Value AnswerValue
FROM ChildAndQuestions 
 LEFT join ChildDemographicDetail on ChildDemographicDetail.ChildId = ChildAndQuestions.ChildId 
					and ChildDemographicDetail.QuetionType = ChildAndQuestions.QuestionType

INNER JOIN DropdownMasterData AnswerMaster ON AnswerMaster.Id = ChildDemographicDetail.answer

Order by ChildAndQuestions.ChildId, QuestionType


--select * from ChildDemographic

--select * from ChildDemographicDetail

