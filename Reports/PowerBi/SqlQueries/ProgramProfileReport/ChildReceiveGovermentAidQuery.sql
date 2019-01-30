
-------------------------------------------------------------
--Child Receiving Goverment Aid
-------------------------------------------------------------

SELECT ChildId,
LTRIM(RTRIM(m.n.value('.[1]','varchar(8000)'))) AS ChildReceiveGovermentAid
FROM
(
SELECT ChildId,CAST('<XMLRoot><RowData>' + REPLACE(ChildReceiveGovermentAid,',','</RowData><RowData>') + '</RowData></XMLRoot>' AS XML) AS x
FROM   ChildAdditionalInformation
)t
CROSS APPLY x.nodes('/XMLRoot/RowData')m(n)