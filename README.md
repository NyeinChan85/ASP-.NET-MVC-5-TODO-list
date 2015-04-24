# ASP .NET MVC 5 TODO list (version 1.0)
========================================

It's a simple to-do-list app created by using ASP.NET MVC 5 models with Entity Framework. It still needs some improvments.
The Model-View-Controller (MVC) architectural pattern separates an application into three main components: the model, the view, and the controller. The ASP.NET MVC framework provides an alternative to the ASP.NET Web Forms pattern for creating Web applications. The ASP.NET MVC framework is a lightweight, highly testable presentation framework that (as with Web Forms-based applications) is integrated with existing ASP.NET features, such as master pages and membership-based authentication. 

The MVC framework includes the following components:

Models
------
Model objects are the parts of the application that implement the logic for the application's data domain. Often, model objects retrieve and store model state in a database. For example, a Product object might retrieve information from a database, operate on it, and then write updated information back to a Products table in a SQL Server database.

Views
-----
Views are the components that display the application's user interface (UI). Typically, this UI is created from the model data. An example would be an edit view of a Products table that displays text boxes, drop-down lists, and check boxes based on the current state of a Product object.

Controllers
-----------
Controllers are the components that handle user interaction, work with the model, and ultimately select a view to render that displays UI. In an MVC application, the view only displays information; the controller handles and responds to user input and interaction. For example, the controller handles query-string values, and passes these values to the model, which in turn might use these values to query the database.

Prerequisites
=============

* Visual Studio 2013
* MVC 5 for ASP .NET
* Microsoft SQL Server Management Studio 2008/2012 (OPTIONAL)
* AZURE cloud platform(OPTIONAL)


You can play around my app. My app is live [here] (http://todolistofnck.azurewebsites.net)

