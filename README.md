## Project-PageViews
The Wikimedia Foundation provides all pageviews for Wikipedia site since 2015 in machine-readable format. 
The pageviews can be downloaded in gzip format and are aggregated per hour per page. 
Each hourly dump is approximately 50MB in gzipped text file and is somewhere between 100MB and 250MB in size unzipped.

## Task 
-	Create a command line application 
-	Get data for last 5 hours 
-	Calculate by the code the following SQL statement 
-	ALL_HOURS table represent all files
-	SQL statement use just to provide you requirements do not use database in your solution.  

SELECT	TOP 100 DOMAIN_CODE, PAGE_TITLE, SUM (count_views) CNT 
FROM	ALL_HOURS 
GROUP BY	DOMAIN_CODE, PAGE_TITLE
ORDER BY	SUM (cont_views) DESC


## How to run this sample
To run this sample, you'll need:

- Visual Studio 2019 or just the .NET Core SDK
- An Internet connection

### Step 1: Clone or download this repository
From your shell or command line:
https://github.com/JeanmarcoLujan/Project-PageViews.git
or download and extract the repository .zip file.

### Step 2: Configure the sample
Open the PageViewsProject\PageViewsProject.Presentation\appsettings.json file
Find the app keys url, hour and replace the existing value with the corresponding values.
- url: uri base where downloading the information (pages)
- hour: the last hours to consulting.

### Step 3: Run the sample
Clean the solution, rebuild the solution, and start it in the debugger.

0 - Determinate url, for the last hours configured, based on the current date and time.

1 - Download the information (files) in memory stream.

2 - Descompression the stream in memory.

3 - Read the stream and generate a list of string.

4 - Instance objets of the class 'Pages' and generate a list of 'Pages'.

5 - Join the diferents results.

6 - Calculate result following  SQL Statement of coding assignment.

7 - Show o print the result.

### Step 4: Result

Top 100
|   #   | domain_code | page_title  | max_ count_views | 
|-------|-------------|:------------|-----------------:|
|   1   | en.m	      | Main_Page   | 305444           | 
|   2   | de          | Google      | 212499           | 
|   3   | es          | tupac Amaru | 157374           | 
|   4   | it.m        | bongur_     | 8545             |

## Developer
Alberto Luján
