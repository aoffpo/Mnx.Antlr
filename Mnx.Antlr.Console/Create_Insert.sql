

IF object_id('tempdb..#BusinessAsset') IS NOT NULL
	DROP TABLE #BusinessAsset

CREATE TABLE #BusinessAsset(
    [BusinessAsset_Id] INT IDENTITY(1,1) NOT NULL,
	[BusinessAssetType_Id] INT NOT NULL,
	[BusinessAsset_Parent_Id] INT NULL,
	[AssetAncestors] VARCHAR(512) NOT NULL,
    [AssetName] NVARCHAR(100)  NOT NULL,
    [AssetDescription] NVARCHAR(max)  NOT NULL,
    [AccountSummary_Id] int  NOT NULL,
	[StartDateTime] DATETIME  NOT NULL,
    [EndDateTime] DATETIME  NOT NULL,
	[IsActiveFlag] BIT NOT NULL,
	[CreatedByDateTime] DATETIME NOT NULL DEFAULT GETUTCDATE(),
	[CreatedByUserSummary_Id] INT NOT NULL DEFAULT 1,
	[UpdatedDateTime] DATETIME NOT NULL DEFAULT GETUTCDATE(),
	[UpdatedByUserSummary_Id] INT NOT NULL DEFAULT 1
)


DECLARE @AssetTypeID INT
DECLARE @ParentID INT=NULL
DECLARE @Ancestors varchar(512) = ''

SELECT @AssetTypeID=BusinessAssetType_Id FROM DSI.BusinessAssetType WHERE AssetTypeName = 'Bridge'
INSERT INTO #BusinessAsset
	([BusinessAssetType_Id]
	,[BusinessAsset_Parent_Id]
	,[AssetAncestors]
	,[AssetName]
	,[AssetDescription]
	,[AccountSummary_Id]
	,[StartDateTime]
	,[EndDateTime]
	,[IsActiveFlag])
     VALUES
			(@AssetTypeID,@ParentID,@Ancestors,'The Brooklyn Bridge','The Brooklyn',2,'1994-08-15 11:11:11','3000-01-01 11:11:11',1)
MERGE DSI.BusinessAsset AS tgt
USING (SELECT * FROM #BusinessAsset) AS src
ON (tgt.AssetName = src.AssetName and (tgt.BusinessAsset_Parent_Id = src.BusinessAsset_Parent_Id or(tgt.BusinessAsset_Parent_Id is null and src.BusinessAsset_Parent_Id is null))and tgt.AccountSummary_ID = src.AccountSummary_ID)
WHEN MATCHED THEN
	UPDATE SET  BusinessAssetType_Id=src.BusinessAssetType_Id,
				BusinessAsset_Parent_Id=src.BusinessAsset_Parent_Id,
				AssetName=src.AssetName,
				AssetDescription=src.AssetDescription,
				[AssetAncestors] = src.AssetAncestors,
				AccountSummary_Id=src.AccountSummary_Id,
				StartDateTime = src.StartDateTime,
				EndDateTime = src.EndDateTime,
				IsActiveFlag = src.IsActiveFlag,
				CreatedByDateTime = src.CreatedByDateTime,
				CreatedByUserSummary_ID = src.CreatedByUserSummary_ID,
				UpdatedDateTime = src.UpdatedDateTime,
				UpdatedByUserSummary_ID = src.UpdatedByUserSummary_ID
WHEN NOT MATCHED BY TARGET THEN
	INSERT ([BusinessAssetType_Id]
			,[BusinessAsset_Parent_Id]
			,[AssetAncestors]
			,[AssetName]
			,[AssetDescription]
			,[AccountSummary_Id]
			,[StartDateTime]
			,[EndDateTime]
			,[IsActiveFlag]
			,CreatedByDateTime
			,CreatedByUserSummary_Id
			,UpdatedDateTime
			,UpdatedByUserSummary_Id)
	VALUES (src.[BusinessAssetType_Id]
			,src.[BusinessAsset_Parent_Id]
			,src.AssetAncestors
			,src.[AssetName]
			,src.[AssetDescription]
			,src.[AccountSummary_Id]
			,src.[StartDateTime]
			,src.[EndDateTime]
			,src.[IsActiveFlag]
			,src.CreatedByDateTime
			,src.CreatedByUserSummary_Id
			,src.UpdatedDateTime
			,src.UpdatedByUserSummary_Id);
SELECT @ParentID = [BusinessAsset_Id]FROM DSI.BusinessAsset WHERE [AssetName] ='The Brooklyn Bridge'			
INSERT INTO #BusinessAsset
	([BusinessAssetType_Id]
	,[BusinessAsset_Parent_Id]
	,[AssetAncestors]
	,[AssetName]
	,[AssetDescription]
	,[AccountSummary_Id]
	,[StartDateTime]
	,[EndDateTime]
	,[IsActiveFlag])
     VALUES
	 (@AssetTypeID,@ParentID,@Ancestors,'The Pedestrian Bridge','The Pedestrian',2,'1994-08-15 11:11:11','3000-01-01 11:11:11',1)
MERGE [DSI].[BusinessAsset] AS tgt
USING (SELECT * FROM #BusinessAsset) AS src
ON (tgt.AssetName = src.AssetName and (tgt.BusinessAsset_Parent_Id = src.BusinessAsset_Parent_Id or(tgt.BusinessAsset_Parent_Id is null and src.BusinessAsset_Parent_Id is null))and tgt.AccountSummary_ID = src.AccountSummary_ID)
WHEN MATCHED THEN
	UPDATE SET  BusinessAssetType_Id=src.BusinessAssetType_Id,
				BusinessAsset_Parent_Id=src.BusinessAsset_Parent_Id,
				AssetName=src.AssetName,
				AssetDescription=src.AssetDescription,
				[AssetAncestors] = src.AssetAncestors,
				AccountSummary_Id=src.AccountSummary_Id,
				StartDateTime = src.StartDateTime,
				EndDateTime = src.EndDateTime,
				IsActiveFlag = src.IsActiveFlag,
				CreatedByDateTime = src.CreatedByDateTime,
				CreatedByUserSummary_ID = src.CreatedByUserSummary_ID,
				UpdatedDateTime = src.UpdatedDateTime,
				UpdatedByUserSummary_ID = src.UpdatedByUserSummary_ID
WHEN NOT MATCHED BY TARGET THEN
	INSERT ([BusinessAssetType_Id]
			,[BusinessAsset_Parent_Id]
			,[AssetAncestors]
			,[AssetName]
			,[AssetDescription]
			,[AccountSummary_Id]
			,[StartDateTime]
			,[EndDateTime]
			,[IsActiveFlag]
			,CreatedByDateTime
			,CreatedByUserSummary_Id
			,UpdatedDateTime
			,UpdatedByUserSummary_Id)
	VALUES (src.[BusinessAssetType_Id]
			,src.[BusinessAsset_Parent_Id]
			,src.AssetAncestors
			,src.[AssetName]
			,src.[AssetDescription]
			,src.[AccountSummary_Id]
			,src.[StartDateTime]
			,src.[EndDateTime]
			,src.[IsActiveFlag]
			,src.CreatedByDateTime
			,src.CreatedByUserSummary_Id
			,src.UpdatedDateTime
			,src.UpdatedByUserSummary_Id);


--generate asset ancestors from data after merge has completed
DECLARE @counter INT
SELECT @counter = COUNT (*) FROM [DSI].[BusinessAsset] 

WHILE @counter <> 0
BEGIN 
	UPDATE DSI.BusinessAsset  SET [AssetAncestors] = [DSI].[GetFullPathToRootStringForBusinessAssetParent](BusinessAsset_Parent_ID)
	WHERE BusinessAsset_ID = @counter
	SELECT @counter = @counter -1
END