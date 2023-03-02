In feature file put tags such as
@Smoke
@Sanity
@Regression
@Sanity, Regression

In Test Explorer, filter under Traits for different tags

cmd commands for different tags
dotnet test --filter TestCategory=Smoke
dotnet test --filter TestCategory=Sanity
dotnet test --filter TestCategory=Regression
dotnet test --filter "TestCategory=Sanity|TestCategory=Regression"
dotnet test --filter "TestCategory=Sanity&TestCategory=Regression"
dotnet test --filter TestCategory=!Sanity