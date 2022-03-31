  begin transaction addfixture
  truncate table main
  insert into [PUC].[dbo].[Main] ([custId],[machineName],[serialNumber],[description],[isActive],[creationDate],[createdBy],[partNumber])
  SELECT [custId]
      ,[machineName]
      ,[serialNumber]
      ,[description]
      ,[isActive]
      ,[creationDate]
      ,[createdBy]
      ,[partNumber]
  FROM [PUC].[dbo].[Sheet2$]
 
  SELECT TOP (1000) [machineId]
      ,[custId]
      ,[machineName]
      ,[serialNumber]
      ,[description]
      ,[isActive]
      ,[creationDate]
      ,[createdBy]
      ,[updateDate]
      ,[updatedBy]
      ,[partNumber]
  FROM [PUC].[dbo].[Main]
  --COMMIT TRANSACTION
  ROLLBACK TRANSACTION addfixture




  --migrate the Main table

SET IDENTITY_INSERT [dbo].main ON 
insert into main ([machineId]
      ,[custId]
      ,[machineName]
      ,[serialNumber]
      ,[description]
      ,[isActive]
      ,[creationDate]
      ,[createdBy]
      ,[updateDate]
      ,[updatedBy]
      ,[partNumber])
SELECT m.Id machineId
--,d.custName
		,d.[custID]
      ,[fixtureID] machineName
	  --,partNumber
      ,[serialNumber]      
      ,[description]     
	  ,m.isactive
      ,[creationDate]
      ,[createdBy]
      ,[updateDate]
      ,[updatedBy]	  
	  ,[partNumber]
  FROM [PUC].[dbo].[CPCC_Main] m
  left join (SELECT c.custName
	,c.[custID]
	,mc.custId cust
  FROM [PUC].[dbo].[Master_Customer] mc
  left join [CommonTE].[dbo].[Customer] c on c.custname = mc.custname) d on d.cust = m.custId
  where custName is not null and m.isActive = 1
  SET IDENTITY_INSERT [dbo].main OFF
 --END migrate the Main table

--migrate the Detail table
  SET IDENTITY_INSERT [dbo].[Detail] ON
insert into detail ([detailId]
      ,[machineId]
      ,[supplierId]
      ,[categoryId]
      ,[partNumber]
      ,[location]
      ,[used_times]
      ,[triggerLimit]
      ,[limit]
      ,[description]
      ,[isActive]
      --,[statusId]
      ,[creationDate]
      ,[createdBy]
      ,[updateDate]
      ,[updatedBy])
SELECT TOP (1000) [detailId]
      ,[fixId] [machineId]
      ,[supplierId]
      ,[categoryId]
      ,[partNumber]
      ,[location]
      ,[used_times]
      ,[triggerLimit]
      ,[limit]
      ,[description]
      ,[isActive]
      ,[creationDate]
      ,[createdBy]
      ,[updateDate]
      ,[updatedBy]
      --,[isPendingApproval]
      --,[updatedName]
      --,[updatedEmail]
      --,[createdName]
      --,[createdEmail]
  FROM [PUC].[dbo].[CPCC_Detail]
  where isActive = 1
  SET IDENTITY_INSERT [dbo].[Detail] OFF
-- END migrate the Detail table