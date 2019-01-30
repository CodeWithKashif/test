with Questions as
(
   select 1 as QuestionType
 union select 2 
 union select 3 
 union select 4 
 union select 5 
 union select 6 
 union select 7
)
,ChildAndQuestions as
(
SELECT 
 Child.Id as ChildId, FirstName, LastName,
 Questions.QuestionType 
FROM Questions,Child
)
select ChildAndQuestions.* ,
ChildDemographicDetail.answer
FROM ChildAndQuestions 
 LEFT join ChildDemographicDetail on ChildDemographicDetail.ChildId = ChildAndQuestions.ChildId 
   and ChildDemographicDetail.QuetionType = ChildAndQuestions.QuestionType
Order by ChildAndQuestions.ChildId, QuestionType