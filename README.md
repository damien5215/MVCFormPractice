# MVCFormPractice

I created this project so that I can practice implementing the repository design pattern, posting data (MVC forms), etc. It doesn't contain a database.

It is adapted from this treehouse project - https://github.com/treehouse-projects/aspnet-fitness-frog

In the project there is a "Data" folder which contains a repository and data class. The data cass is static and creates a list of books. The respository contains CRUD operations which returns the entire list of books, get the info for one specific book, etc.

NOTE - The code in this class (Data) is not to be considered a "best practice" example of how to do data persistence, but rather as workaround for not having a database to persist data to.

This project involves - 

1. Creating Forms for CRUD Applications
2. Handling Form Posts
3. Model State
4. Using HTML Helpers to Create Form Fields
5. Model Binding
6. Client-Side and Server-Side Form Validation

Concepts Learned - 

MVC’s model binding process will attempt to set an action method’s parameter values by looking for request form fields, route data, or request query string parameters with the same names.

The post/redirect/get pattern is a commonly used web development design pattern for preventing duplicate form submissions.

The ModelState property, provided by the Controller base class, contains a collection of the name/value pairs posted to the server along with a collection of error messages for each value submitted.

MVC gives priority to the ModelState values over the Model property values as long as there are ModelState values present.

SelectListItem is a simple object that’s used to represent an item in a drop down list. In addition to the SelectListItem class, MVC provides the SelectList class as a convenience for creating a collection of SelectListItem objects.

The AddModelError method can only be used to implement server-side validation rules.

Nullable properties can be made to be validated as required by adding a [Required] data annotation to the property.

The MVC model binder will automatically validate non-nullable value type properties as “required” fields.

A validation summary section can be added to a view by calling the ValidationSummary HTML helper method.

Both the “UnobtrusiveJavaScriptEnabled” and “ClientValidationEnabled” app settings must be set to “true” to enable client-side validation (web.config).

Performing a GET request should always be a “safe” action to make, so it should not be used with action methods that modify records. For that reason, controller action methods that delete records are typically restricted to POST requests.

Which of the following MVC data collection properties can be used to pass data from the current request to the next request? (TempData).

MVC partial views allow you to share HTML and Razor code between one or more views. Partial views allow us to keep our view code DRY (code that follows the “Don’t Repeat Yourself” design principle).

This Controller base class method, "HttpNotFoud", makes it easy to return a 404 “Not Found” response to the client.