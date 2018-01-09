Preperation:

	VS Solution
	-----------
	Folder: "Visio DataFlow R2"  (Visual Studio 2017)
	Simpified VSTO for Visio 2016

	Data
	-----
	SQL.sql  (Sql Server 2008 R2)
	Creates schema, table, data, stored procedure that will feed the application's DataGrdiView.

	Template:
	-----------
	Test.vstx
	Custom Visio Template with Persistent Events to call Add-In functions.
	
	

Once the application is running: 
---------------------------------
1) Open the template "Test.vstx"
2) Add shape to drawing (Basic Shape is fine)
3) A form should open
4) Click button 'button1'
5) Form's grid should populate
6) Close form with (x) top right.
7) Repeat from (2)

** In my tests, I get to repeat the 'add shape' sequence between 1-6 times before the form stops appearing.
*By lowering the number of rows fed to the datagridview, the number of shapes added increases to 18-20.
*By scrolling the dgv to the last rows of 1100, the error occurs after only 1 or 2 shapes.

