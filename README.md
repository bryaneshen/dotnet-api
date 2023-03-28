Application Architecture:
![image](https://user-images.githubusercontent.com/47930778/226523486-5b5460f1-b684-4b8b-b3e9-470bdd57e6b8.png)

These are the API endpoints that are implemented for the REST API.
![image](https://user-images.githubusercontent.com/47930778/228362596-5376478e-7eba-44fd-91a3-794fd3cd4413.png)

Utilizing dependency injection throughout the application.
<img width="1462" alt="image" src="https://user-images.githubusercontent.com/47930778/227011535-ba5f8352-989c-40ae-94b1-69469d675ec4.png">
Within our controller class, we'll be creating a constructor and we will expect an ICommanderRepo instance. When the constructor is then called, the dependency injection system will inject a dependency.
We registered our service into the service container by using AddScoped, which is done by creating a new object for every client request.

We use migrations (from the EF Core) so that it allows us to update the database schema to keep it in sync with the application's data. This also allows us to preserve the existing data in the database.

![image](https://user-images.githubusercontent.com/47930778/228169296-c7b490e5-38ca-49b2-8c09-5edc04320813.png)
An external Data transfer object will be used in order for us to represent the data that our application holds. 

![image](https://user-images.githubusercontent.com/47930778/228169821-7afc88b8-3590-4d31-9130-b27ca9cccd7f.png)
The DTO is what will be passed back to the client from a request.
