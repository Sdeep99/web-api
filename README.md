# Library Management System

This is a library management system created in .NET Core (MVC) using C#. The Library Management System aims to streamline the management of library resources, including books, members, and publishers.

## Project Description

### Goals and Functionalities:

* User management for Members and Librarians.
* Member management for creating, updating, and deleting member profiles.
* Librarian management for creating, updating, and deleting librarian profiles.
* Categorizing books into different categories.
* Managing book details including their publishers.
* Basic CRUD operations for books, members, librarians, categories, and publishers.

## User Roles and Permissions:
Users can sign up for their profile and receive a confirmation email.

### Member:
* Can manage their own profile.
* Can view available books and their details.

### Librarian:
* Can manage their own profile.
* Can manage book details.
* Can manage member profiles.

## Technologies Used:

* Backend Framework: .NET Core (C#) is utilized for building the RESTful backend service.
* Database: SQLite is chosen for data storage.
* Entity Framework handles data access.
* Identity Framework manages user authentication.
* JWT tokens secure API requests.
* Dependency Injection enhances code organization.
* Logging is implemented for tracking application events.


### Pre-requisites:
* Microsoft Visual Studio Code.
* Postman for testing.
* DOTNET Core SDK.

## Implementation of .NET Core RESTful Backend Service:

### Controllers
The system includes controllers for user management, member management, librarian management, book management, category management, and publisher management. These controllers implement CRUD operations for relevant entities.

### Models
* User representing members and librarians.
* Member storing member-specific information.
* Librarian storing librarian-specific information.
* Book storing book-specific information.
* Category categorizing books.
* Publisher storing publisher-specific information.

### Dependency Injection and Logging
Dependency Injection is employed for better code organization, and logging is implemented to track application events.

## Database Design: 
<img src="https://github.com/Sdeep99/web-api/blob/main/classdiagram.png"/>

## How to Run
1. Install Microsoft Visual Studio Code, Postman, and .NET Core SDK.

2. Open the project in Microsoft Visual Studio Code and run the following command: dotnet run.

3. Use the localhost port number provided in the terminal to test API endpoints using Postman.