SELECT 
 Child.Id as ChildId, FirstName, LastName, Gender,
 ChildDemographic.SubEthinicityId, SubEthinicity.Name as SubEthinicityName,
 Ethinicity.Id AS EthinicityId, Ethinicity.Name as EthinicityName,
 LanguageAtHome.Id PrimaryLanguageIdSpokenAtHome, LanguageAtHome.Name as PrimaryLanguageNameSpokenAtHome,
 NativeLanguages.Id NativeLanguageId, NativeLanguages.Name as NativeLanguageName,
 ChildDemographic.EnglishSkill
FROM Child
 Inner join ChildDemographic on ChildDemographic.ChildId = Child.Id
 Inner join SubEthinicity on SubEthinicity.Id = ChildDemographic.SubEthinicityId
 Inner join Ethinicity on Ethinicity.Id = SubEthinicity.EthinicityId
 Left join Languages as LanguageAtHome on LanguageAtHome.Id = ChildDemographic.PrimaryLanguageSpokenAtHome
 Left join ChildNativeLanguages on ChildNativeLanguages.ChildId = Child.Id
 Left join Languages as NativeLanguages on NativeLanguages.Id = ChildNativeLanguages.Language

Order by ChildId