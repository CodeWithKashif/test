SELECT 
	Child.Id as ChildId, Child.FirstName, Child.LastName,
	IsParticipatedInPchp, ReceiveSpecialEducationService, IsSiblingEligibleForFreeLunch
FROM Child 
	LEFT JOIN ChildSibling ON ChildSibling.ChildId = Child.Id
