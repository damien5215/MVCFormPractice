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