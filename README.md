# WebAppProject - Online Library Management System

## Overview:
The Online Library Management System is used to manage all textbooks at the library and all textbooks rented by student. It will have CRUD methods, and be able to give a list of rented books, and overdue textbooks. Also, it can check the the textbook reserved by student to pick up. Maybe, if a textbook is available in pdf format, it will give students a link to download it.
Students may have their own textbook rental dashboard that helps them keep track of textbook's return date. Also, they may reserve a textbook online and come to pick it up at the library, and a controller will tell make a text book as reserved status in the database.

## How it works?
As a librarian:
  * Be able to create, update, read, and delete textbooks
  * Be able to check a list of rented textbooks, a list of overdue textbooks, and a list of reserved textbooks
  * Send an email to a student to remind them to return the textbook
  * thinking more ....

As a student:
  * Be able to see what they are renting and the return date.
  * Get a notification if they have a overdue textbook
  * Reserve a textbook online. Within 1 day, if they don't pick up, the reservation will be cancelled.
  * Search for textbooks and maybe get a link to download it if it is a free pdf file.
  * Extend the textbook rental if there are more than 3 same textbooks available.
  
## Database Context:
#### LibDatabase database (for storing book, student, librarian, etc):
Student Table - DbSet<> Student
  * StudentID - int
  * StudentFirstName - strintg
  * StudentLastName - string
  * StudentEmail - string
  
Librarian Table - DbSet<> Librarian
  * LibrarianID - int
  * LibrarianFirstName - string
  * LibrarianLastName - string
  * LibrarianEmail - string
  * LibrarianPassword - string (for log in and security purpose)
  
Book Table - DbSet<> Book
  * BookID - string
  * BookName - string
  * Author - string
  * Edition - string
  * ISBN - long
  * Subject - string
  * PublicDate - DateTime
  * Format - String
  * NumOfpages - int
  
 RentedBook Table - DbSet<> RentedBook
  * Student ID - int
  * BookID - int
  * IssueDate - DateTime
  * ReturnDate - DateTime
  
#### Authentication database (for register and login):
 AspNetRoleClaims table
   * Id - int
   * RoleId - nvarchar
   * ClaimType - nvarchar
   * ClaimValue - nvarchar
   
 AspNetRole table
  * Id - int
  * Name - nvarchar
  * NormalizedName - nvarchar
  * ConcurrencyStamp - nvarchar
  
 AspNetUserClaims table
   * Id - int
   * UserId - nvarchar
   * ClaimType - nvarchar
   * ClaimValue - nvarchar  

 AspNetUserLogins table
   * LoginProvider - nvarchar
   * ProviderKey - nvarchar
   * ProviderDisplayName - nvarchar
   * UserId - nvarchar
 
 AspNetUserRoles table
   * RoleId - nvarchar
   * UserId - nvarchar
   
 AspNetUserRoles table
   * Id - int
   * UserName - nvarchar
   * NormalizedUserName - nvarchar
   * Email - nvarchar
   * NormalizedEmail - nvarchar
   * PasswordHash - nvarchar
AspNetUserTokens table
   * UserId - nvarchar
   * LoginProvider - nvarchar
   * Name - nvarchar
   * Value - nvarchar

  There may be more tables as the progress continues
  
  ## WebApp1b - Updated (07/20/2019):
  What's done:
  * Almost completed the front-end
    * Please note: the search bar is displayed visually, but still not functional
  * Implemented CRUD methods for book database as librarian
  * Student now can check what they are renting
  * Created tables for database
  
  For Student page, the current student on the dashboard is #ID 2, which is John. To get the student ID with ID# 1 show up, you may need to change asp-route-id=1 on the navigation bar at _Layout.cshtml (Views/Shared/_Layout.cshtml).
Therefore, the For Students need a login page for each student to manage their own textbook rental.
  
  ## WebApp2 - Updated (08/03/2019):
  What's done:
  * Added Login and Register page for authentication, and created a database for user authentication. The database name for authentication is aspnet-LibraryManagementWithAuthen-EE9ABA9C-C6FF-48D5-AF35-C54855C5F163, and the database for book, student, etc is LibDatabase3.
  * Registering and logging in is working properly. However, the autherization for the users: student and librarian is not created.
  
  Things to do:
  * While logging in, authorize the user. If the user is student, then redirect to student page or student's book rental dashboard (For Student). If the user is librarian, then redirect to librarian page (For Librarian).
  * Work on other features: list of overdue books, list of reserved book, reserve online, and notification of overdue book on student page.
  
    
