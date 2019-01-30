
SELECT 
        Child.Id AS ChildId,Child.FirstName AS ChildFirstName,Child.LastName AS ChildLastName,
        ProgramYear.Id As ProgramYearId, ProgramYear.ProgramYearName, 
        [Site].Id AS SiteId, [Site].Name AS SiteName,
		Region.Id AS RegionId, Region.Name AS RegionName,
        ChildProgramYearBridge.ProgramCycle,
        ChildProgramYearBridge.ProgramStartDate,ChildProgramYearBridge.ProgramEndDate,
        ScheduleCount.PendingSessions, ScheduleCount.CompletedSessions, 
        (PendingSessions + CompletedSessions) AS TotalSessions
FROM 
    ChildElsSchedule
LEFT JOIN ChildProgramYearBridge ON ChildProgramYearBridge.Id = ChildElsSchedule.ChildProgramYearBridgeId
                        AND ChildProgramYearBridge.IsDeleted = 0              
LEFT JOIN Child ON Child.Id = ChildProgramYearBridge.ChildId AND ISNULL(Child.IsDeleted, 0)= 0
INNER JOIN [Site] ON Child.SiteId =[Site].Id AND ISNULL([Site].IsActive, 0)= 1 AND ISNULL([Site].IsDeleted, 0)= 0                                    

LEFT JOIN SiteRegionBridge ON SiteRegionBridge.SiteId = [Site].Id 
LEFT JOIN Region ON Region.Id=SiteRegionBridge.RegionId

LEFT JOIN VismSchedule ON ChildElsSchedule.ScheduleId = VismSchedule.Id
                        AND ISNULL(VismSchedule.IsActive, 0)= 1 and ISNULL(VismSchedule.IsDeleted, 0)= 0
LEFT JOIN ProgramYear ON ChildProgramYearBridge.ProgramYearId = ProgramYear.Id
                        AND ISNULL(ProgramYear.IsActive, 0)= 1 and ISNULL(ProgramYear.IsDeleted, 0)= 0
LEFT JOIN 
(
    SELECT 
            SUM(CASE WHEN ISNULL(ChildElsScheduleDetail.[Status],0)=0 THEN 1 ELSE 0 END ) AS PendingSessions, 
            SUM(CASE WHEN ISNULL(ChildElsScheduleDetail.[Status],0)=1 THEN 1 ELSE 0 END ) AS CompletedSessions,
            ChildElsScheduleDetail.ChildElsScheduleId 
    FROM 
            ChildElsScheduleDetail 
    WHERE ISNULL(ChildElsScheduleDetail.IsDeleted, 0) = 0 
    GROUP BY ChildElsScheduleDetail.ChildElsScheduleId
)
ScheduleCount ON ScheduleCount.ChildElsScheduleId=ChildElsSchedule.Id 
WHERE 
    ISNULL(ChildElsSchedule.IsDeleted, 0) = 0  
            --AND ChildProgramYearBridge.ChildId = 4181
    Order By ProgramYearName ASC 
 