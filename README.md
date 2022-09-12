# dotnet-console-trade-category
This is a .NET 6 Console Application that categorize trades in a bank`s portifolio.


## Application
This console applilcation is a solution to categorize trades of a bank`s portifolio. Currently, there are three categories (in order of precedence):

1. EXPIRED: Trades whose next payment date is late by more than 30 days based on a reference date which will be give.
2. HIGHRISK: Trades with value greater than 1,000,000 and client from Private Sector.
3. MEDIUMRISK: Trades with value greater than 1,000,000 and client from Public Sector.

The design must be extensible allowing those categories to be easily added/removed/modified in the future.


## Design Solution
A new category was created called PEP (politicaly exposed person). Also, a new bool property IsPoliticallyExposed was created in the ITrade interface. A trade shall be categorized as PEP if IsPorliticallyExposed is true. Describe in at most 1 paragraph what you must do in your desig to account for this new category.

### Answer

A new PoliticallyExposedCategory class must be created, implementing the ICategory interface. This interface is implemented by all Categories, having a "Name" method to return the category name and "IsCategoryOfTrade", which validates if the trade belongs to the respective category. An instance of PoliticallyExposedCategory must be created right at the top of the CreateCategory method in the CategoryFactory. This factory, return the instace of category clssified of the Trade. Also, the new paramenter must be created at Trade class and new unit tests must be included in CategoryTest.

# Desigin Patternes and Principles
The solution uses Object-Oriented Principles (OOP) and Factory Method Design Pattern. Furthermore, the projects are structured with Domain-Drive Design, using Dependency Injection of the created services and extension classes in the input/output service. Unit tests were created using Mock and XUnit Frameworks.

