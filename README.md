# DependencyInjectionProject
This is a console application to represent the dependency injection.
Human can be boy or girl.
So based on input 1 or 2, displays hello message from a boy or girl.

For a class Human is dependent on Boy or Girl class which indicates tight coupling.
To reduce dependency between two classes, an interface Iperson is introduced and inherited by Boy and Girl classes.
Dependency=> Object of Boy or Object of Girl is injected to object of Human as per input 1 or 2.

Hereby, Human is a dependent(Client) and Boy or Girl is dependency(services). 
We can clearly say dependent is consuming dependencies as per need.
