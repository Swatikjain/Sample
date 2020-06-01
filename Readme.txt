This application is built to maintain contact information. Its developed in Dot net technology, mvc as front end, web api as middleware and sql server as backend. This application contains below functionalities -
List Contacts
Add a contact
Edit contact
Delete/inactivate a contact

Folder structure of the application is as follows-
1. ContactsWebApi - it acts as a middleware between web app and backend. It is built in Dot net core 2.2 which has dependency injection implemented (Please refer Startup.cs). There is an action defined for every request.
2. ContactsWebApplication - This is a web application built in MVC. For users every request, an action is being called which in turns call web api and returns response to UI.
3. Domain - It has service class which is called web api action and will call Repository.
4. Repository - It is used to interact with Database with the help of Entity Framework. It has context and Repository classes. 

How to Run the application -
1. Open command Prompt, go to path where your application is saved on local drive.
2. Go to "\\ContactsWebApplication\ContactsWebApplication\bin\Release\netcoreapp2.2\publish" in command prompt.
3. Run "dotnet ContactsWebApplication.dll" command.
4. Application Started message should come.
5. Open solution in visual studio.
6. Run ContactsWebApi.
7. Browse the url of ContactsWebApplication and application should get launched with Index page.
