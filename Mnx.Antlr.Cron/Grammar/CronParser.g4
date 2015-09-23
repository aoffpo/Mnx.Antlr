parser grammar CronParser;
options { tokenVocab=CronLexer; } 
@parser::header {#pragma warning disable 3021}

//Days	
//	Every X day(s)*		Every 9 days (including weekends)
//	Every Weekday		Every Weekday
//Months
//	Day X of every X month(s)				
//						Day 1 of every 4 months
//	The (First/2nd/3rd/4th/5th/Last) (Weekday/Weekend day/M/T/W/Th/F/Sa/Su) of every X month(s)	
//						The first Tuesday of every 2 months
//Weeks	
//	Every X weeks on (M/T/W/Th/F/Sa/Su) 	
//						Every 3 weeks on Monday and Wednesday
//Years	
//	Day X of (Jan/Feb/Mar/April....),every X years		
//						June 15th every 2 years
//	The (First/2nd/3rd/4th/5th/Last) (Weekday/Weekend day/M/T/W/Th/F/Sa/Su) of (Jan/Feb/Mar/April....), every X years 	
//						The first Weekday of April, every 1 year


statement
	: schedule EOF
	;
schedule 
	: daily
	| weekly
	| monthly
	| yearly 
	;
daily
	: EVERY DIGIT DAY					#DailyDay		//Every X days
	| EVERY WEEKDAY						#DailyWeekday	//Every Weekday	
	;
monthly 
	: DAY DIGIT eachmonth				#MonthlyDay		//Day X of every X Months
	| THE ORDINAL DAYOFWEEK eachmonth	#MonthlyOrdinal	//the first dayofweek of every X Months
	//| THE ORDINAL WEEKEND eachmonth	#MonthlyWeekend	//the 1st/2nd3/rd/4th/5th Weekend of every x months
	//| THE ORDINAL WEEKDAY eachmonth	#MonthlyWeekday	//the  1st/2nd3/rd/4th/5th Weekday of every x months
	;
weekly
	: EVERY DIGIT WEEK ON DAYOFWEEK (AND DAYOFWEEK)*	//Every X weeks on (M/T/W/Th/F/Sa/Su) 	
	;
yearly
	: DAY DIGIT+ (OF MONTHOFYEAR)? eachyear			#YearlyDay		//Day X of (Jan/Feb/Mar/April....),every X years
	| THE ORDINAL DAYOFWEEK OF MONTHOFYEAR eachyear	#YearlyOrdinal	//The (First/2nd/3rd/4th/5th/Last) (Weekday/Weekend day/M/T/W/Th/F/Sa/Su) of (Jan/Feb/Mar/April....), every X years
	;
eachmonth
	: OF EVERY DIGIT+ MONTH
	;
eachyear
	: COMMA? EVERY DIGIT YEAR 
	;