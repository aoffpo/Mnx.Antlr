SET NOCOUNT ON

DECLARE @marketId INT = 0
DECLARE @tzinfoid NVARCHAR(30)

SELECT @tzinfoid = CASE WHEN timezone_offset = -5 THEN 'America/New_York'
				   WHEN timezone_offset = -6 THEN 'America/Indiana/Indianapolis' 	  	
						END
FROM dbo.Market

SELECT 'market_' + CAST(@marketId as varchar(2)) + ': {
	"name": "'  + market + '",
	"range": ' + CAST([range] as varchar(2)) + ',
	"latitude": ' + CAST(latitude as varchar(8)) + ',
	"longitude": ' + CAST(longitude as varchar(8)) + ',
	"timezone": "' + @tzinfoid + '",
	"cities": [ '
FROM dbo.Market
WHERE id = @marketId
SELECT 
'{
	"fullname": "' +city_state + '"
	},'
FROM dbo.City c WHERE market_id = @marketId
SELECT']}'
 SET NOCOUNT OFF