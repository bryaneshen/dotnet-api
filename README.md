Overview of the application
![image](https://user-images.githubusercontent.com/47930778/226523486-5b5460f1-b684-4b8b-b3e9-470bdd57e6b8.png)

Utilizing dependency injection throughout the application.
<img width="1462" alt="image" src="https://user-images.githubusercontent.com/47930778/227011535-ba5f8352-989c-40ae-94b1-69469d675ec4.png">
Within our controller class, we'll be creating a constructor and we will expect an ICommanderRepo instance. When the constructor is then called, the dependency injection system will inject a dependency.
We registered our service into the service container by using AddScoped, which is done by creating a new object for every client request. \n

We use migrations (from the EF Core) so that it allows us to update the database schema to keep it in sync with the application's data.
