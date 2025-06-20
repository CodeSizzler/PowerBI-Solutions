// ---------- Core Summary KPIs ----------
var m1 = Model.Tables["legal_data"].AddMeasure("Total Cases", "COUNT(legal_data[Case_ID])");
m1.FormatString = "#,0";

var m2 = Model.Tables["legal_data"].AddMeasure("Total Billable Hours", "SUM(legal_data[Billable_Hours])");
m2.FormatString = "#,0";

var m3 = Model.Tables["legal_data"].AddMeasure("Average Billable Hours", "AVERAGE(legal_data[Billable_Hours])");
m3.FormatString = "#,0.00";

var m4 = Model.Tables["legal_data"].AddMeasure("Total Settlement Amount", "SUM(legal_data[Settlement_Amount])");
m4.FormatString = "$#,0";

var m5 = Model.Tables["legal_data"].AddMeasure("Average Hourly Rate", "AVERAGE(legal_data[Hourly_Rate])");
m5.FormatString = "$#,0.00";


// ---------- Client & Case Quality ----------
var m6 = Model.Tables["legal_data"].AddMeasure("Average Client Satisfaction", "AVERAGE(legal_data[Client_Satisfaction_Score])");
m6.FormatString = "#.00";

var m7 = Model.Tables["legal_data"].AddMeasure("Average Legal Complexity", "AVERAGE(legal_data[Legal_Complexity_Score])");
m7.FormatString = "#.00";

var m8 = Model.Tables["legal_data"].AddMeasure("High Value Client Count", 
    "CALCULATE(COUNT(legal_data[Case_ID]), legal_data[Is_High_Value_Client] = TRUE())");
m8.FormatString = "#,0";

var m9 = Model.Tables["legal_data"].AddMeasure("Pro Bono Case Count", 
    "CALCULATE(COUNT(legal_data[Case_ID]), legal_data[Is_Pro_Bono] = TRUE())");
m9.FormatString = "#,0";


// ---------- Outcome-Based ----------
var m10 = Model.Tables["legal_data"].AddMeasure("Won Case Count", 
    "CALCULATE(COUNT(legal_data[Case_ID]), legal_data[Outcome] = \"Won\")");
m10.FormatString = "#,0";

var m11 = Model.Tables["legal_data"].AddMeasure("Lost Case Count", 
    "CALCULATE(COUNT(legal_data[Case_ID]), legal_data[Outcome] = \"Lost\")");
m11.FormatString = "#,0";

var m12 = Model.Tables["legal_data"].AddMeasure("Settlement Rate", 
    "DIVIDE(CALCULATE(COUNT(legal_data[Case_ID]), legal_data[Outcome] = \"Settled\"), [Total Cases])");
m12.FormatString = "0.00%";

var m13 = Model.Tables["legal_data"].AddMeasure("Win Rate", 
    "DIVIDE([Won Case Count], [Total Cases])");
m13.FormatString = "0.00%";


// ---------- Duration ----------
var m14 = Model.Tables["legal_data"].AddMeasure("Average Case Duration (Days)", 
    "AVERAGEX(legal_data, DATEDIFF(legal_data[Filed_Date], legal_data[Closed_Date], DAY))");
m14.FormatString = "#,0";

