Cameron Fisher ST10081715 PROG7311 Task 2
Application: Visual Studio 2022. ASP.net web application (.net framework) 

PLEASE NOTE: NAME OF APPLICATION IS NOT MY STUDENT NUMBER, ITS A TYPO. My student number is ST10081715
Name of project: FarmCentralST10091815 

Employee Login Details:
Username - E007
Password - admin

Farmer Login Details:
Username - F210499
Password - Farmer1

------------------------------------------------------------------------------------------------------------------------------------------

Farm Central:

This web forms application was designed to allow Employees to create a profile for a farmer. The farmer is then able to login, and then
add products to a database. The farmer will then be able to store all their products.

------------------------------------------------------------------------------------------------------------------------------------------

Pages:

Default.aspx (Home) - 

This is the first page that the Employee/Farmer will see. This page allows the user to Login, and acces the About and Contact pages.
About and Contact is provided in the navigation bar on top of the page.

About.asspx (About us) -

Provides a short description for the user on the purpose of this application.

Contact.aspx (Contact us) -

Gives the user some contact info.

------------------------------------------------------------------------------------------------------------------------------------------

Employee.aspx (Login) -

This will allow the user to login to the application. Login details already exist for the Employee user, the login details are provided at the top of this ReadMe. The user is required to enter their username and password, then they will click "Login". If the user enters invalid inputs they will need to re-enter the inputs.

Farmer.aspx (Login) -

This will allow the user to login to the application. Login details for the Farmer user needs to be created by the Employee. Once the Farmer has their login details they can then login to the application.

------------------------------------------------------------------------------------------------------------------------------------------

EmployeeDash.aspx (Dashboard) -

This page is used by the Employee only. The Employee is able to add a farmer profile to the databse so that a farmer can login to the FarmerDash.apsx page. When the Employee is adding a farmer profile they need to enter the farmers Username, Email address, Contact number, and Password. The password that the employee creates for the Farmer gets hashed and stored in the database.

The grid will only appear once a farmer has sent Product data to the database.

The Employee SHOULD be able to select a specific farmer username provided in a dropdown box. Once the farmer is selected their products is displayed below.

Filter products allows the Employee to only see a certain product type (Vegetables, Fruits, or Meats).

FarmerDash.aspx (Dashboard) -

Once the Farmer has login into the application they are able to enter details for a products and it will be stored in the database.
The Farmer needs to enter the products product id, product name, and haresting date. the farmer has the option to do it for three product categorys. The Farmer then clicks the "Send To Database" button which will send the data to the databse. each button is responsible for its inputs provided above it.

The Farmer should be able to see the products theyve just sent to the databse.

------------------------------------------------------------------------------------------------------------------------------------------

DBconnectionS.cs:

This class was created to deal with all the communication between the application and the database. It inserts and retrieves data thats required on the pages of the application.