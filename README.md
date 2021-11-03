# Test Automation Template

Created for DataArt IT Leaders free mentorship program.
Contains template for automation codebase using C# + .NET 5.

# Layers (projects)

Automation Template solution consists of a few layers, that can reference each other. To avoid cirricular reference, please, check the guide below with information about template referecing.

## Common

All starts here. Common should NOT reference ANY other project in AutomationTemplate solution, because it contain base code for all other projects.
Any project can reference Common.
Common can contain base test class, JSON configs for all solution (for example with URLs to the application) and helpers, that are applicable for all or many projects in this solution.
#### Can reference: NO project

## Models

Contains all business models of the application under test. These models can be used both in API and UI layers, if it is needed.
For example, you can create model for registration form, and use it both for UI and API tests.
#### Can reference: Common

## UI.PageObjects

Contains ONLY page object classes for the UI autotests. Please, avoid hard logic in PageObject classes. Use UI.Services projects for it. 
#### Can reference: Common, Models, UI.Services

## UI.Services

Contains all helpers and services, needed for PageObjects or tests (for example, calculation logic can be stored in this project, or logic of using specific data on the page)
#### Can reference: Common, Models

## UI.Tests

Contains all UI tests. You should not lay any helper classes in UI.Tests project, because it should contain ONLY test classes.
#### Can reference: Common, Models, UI.PageObjects, UI.Services

## Api.Services

Contains all helpers and services, needed for API tests, or receiving\sending API data. If some UI tests uses API for preconditions, needed classes should be moved in Common layer.
#### Can reference: Common, Models

## Api.Tests

Contains all Api tests. You should not lay any helper classes in UI.Tests project, because it should contain ONLY test classes.
#### Can reference: Common, Models, Api.Services