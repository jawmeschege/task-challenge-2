# challenge2
creating a set of API endpoints defined:
GET /productCategories
POST /productCategory
GET /products
GET /products/<categoryId>
POST /products
PUT /products 
POST /productAttributes
GET /productAttributes
GET /productAttributeValues/<attributeId>
  
#Tasks on the branch
1. Create and use classes to model your entities and relationships and
observe object oriented programming.
2.Ensure endpoints are working and can be seen to work on postman
3.Use a web api framework to implement the API.
4.Handle a range of HTTP error codes and specific error messages.

#Folders 
The following folders will be used in this repository to enhance the use of OOP for code usability and ease of maintenance (NB: To be updated on creation) Internal storage will be used to test the working of the endpoints before integrating to mysql database:

 1.Controllers
 2.Helpers
 3.Mapping
 4.Models
 5.Repositories
 6.persistence
 6.Responses
 7.Services
  
#Branches
 Master is the main branch
 Staging testing and QA branch
 Dev is for development purposes
  
All branches are to create pull requests which whill then be merged with dev if approved at development stage and thereafter moved to staging and if confirmed moved to master for production.
