# Project Overview

## 1. Project Overview
- **Project name:** Petty Cash Management System
- **Purpose:** A Windows Forms-based petty cash management application for tracking cash entries, expenses, and categories, with dashboard summary visualization.
- **Description:** The system supports adding, editing, viewing, and deleting cash entries, categories, and expenses. It also provides a dashboard with totals, balance calculations, expense category breakdowns, and recent expense charts.
- **Technology stack:**
  - Language: C#
  - Framework: .NET 10.0 / .NET 10.0-windows
  - UI: Windows Forms
  - Data access: ADO.NET using raw SQL queries via `Microsoft.Data.SqlClient`
  - Charting: `LiveChartsCore.SkiaSharpView.WinForms`
  - Configuration: `System.Configuration.ConfigurationManager`

## 2. Database
- **Database used:** Microsoft SQL Server (via SQL Server connection string and `Microsoft.Data.SqlClient` provider)
- **Data access method:** ADO.NET with `SqlConnection`, `SqlCommand`, and `SqlDataReader`
- **Connection string location:** `PettyCash.WindowsApp/App.config` under `<connectionStrings>` with name `PettyCashDB`

## 3. Database Tables / Models
The application defines three database tables and corresponding domain models.

### Categories
- **Columns:**
  - `Id` INT IDENTITY(1,1) PRIMARY KEY
  - `Name` NVARCHAR(100) NOT NULL
  - `Description` NVARCHAR(500) NULL
- **Model:** `PettyCash.Core.Models.Category`
  - `int Id`
  - `string Name` (required)
  - `string? Description`

### CashEntries
- **Columns:**
  - `Id` INT IDENTITY(1,1) PRIMARY KEY
  - `Amount` DECIMAL(18,2) NOT NULL
  - `Date` DATETIME2 NOT NULL
  - `Note` NVARCHAR(500) NULL
- **Model:** `PettyCash.Core.Models.CashEntry`
  - `int Id`
  - `decimal Amount`
  - `DateTime Date`
  - `string? Note`

### Expenses
- **Columns:**
  - `Id` INT IDENTITY(1,1) PRIMARY KEY
  - `Title` NVARCHAR(200) NOT NULL
  - `Amount` DECIMAL(18,2) NOT NULL
  - `Date` DATETIME2 NOT NULL
  - `Category` NVARCHAR(100) NOT NULL
  - `Description` NVARCHAR(1000) NULL
- **Model:** `PettyCash.Core.Models.Expense`
  - `int Id`
  - `string Title` (required)
  - `decimal Amount`
  - `DateTime Date`
  - `string Category` (required)
  - `string? Description`

### DashboardSummary
- **Model:** `PettyCash.Core.Models.DashboardSummary`
- **Fields:**
  - `decimal TotalCashAdded`
  - `decimal TotalExpenses`
  - `decimal Balance` (computed: `TotalCashAdded - TotalExpenses`)
  - `int ExpenseCount`
  - `int CashEntryCount`
  - `IList<Expense> RecentExpenses`
  - `IDictionary<string, decimal> ExpenseByCategory`
  - `IDictionary<string, decimal> MonthlyExpenses`
- This model is used as a view model for dashboard data and is not persisted directly in the database.

## 4. Relationships
- There are no enforced foreign key relationships in the database schema.
- The `Expenses` table stores category membership as a plain `Category` string rather than a database foreign key.
- Implicit relationship by convention:
  - `Expenses.Category` holds an expense category name that can correspond to entries in the `Categories` table.
- No One-to-One, One-to-Many, or Many-to-Many relationships are defined at the database level.

## 5. Enums / Choices / Constants
The application uses simple enums to represent form mode states.

- `PettyCash.WindowsApp.Forms.AddCashModeEnum`
  - `Add`
  - `Edit`
  - `View`
- `PettyCash.WindowsApp.Forms.CategoryFormMode`
  - `Add`
  - `Edit`
  - `View`
- `PettyCash.WindowsApp.Forms.ExpenseFormModeEnum`
  - `Add`
  - `Edit`
  - `View`

## 6. API Endpoints / Routes (if applicable)
- The project does not expose any web API endpoints or HTTP routes.
- It is a desktop Windows Forms application only.

## 7. Core Functionalities
The project is structured into core services and Windows Forms UI views.

### Core features
- Cash entry management
  - Add new cash entries
  - Edit existing cash entries
  - View cash entry details
  - Filter cash entries by date and minimum amount
- Expense management
  - Add new expenses
  - Edit existing expenses
  - View expense details
  - Delete expenses
  - Filter expenses by title, date, and category
- Category management
  - Add new categories
  - Edit existing categories
  - View category details
  - Delete categories
  - Search categories by name or description
- Dashboard summary
  - Total cash added
  - Total expenses
  - Current balance
  - Expense count and cash entry count
  - Expense breakdown by category
  - Monthly expense chart for recent months
  - Recent expenses list

### Application wiring
- `PettyCash.WindowsApp/Program.cs` initializes configuration, database schema, repository instances, and service instances.
- The main UI is `MainForm`, which hosts the following views:
  - `DashBoardView`
  - `ExpenseView`
  - `CashView`
  - `CategoryView`

## 8. Authentication & Authorization
- There is no authentication or authorization mechanism in this project.
- No roles, permissions, login, or access control are implemented.

## 9. File & Folder Structure
The repository has two main projects:

- `PettyCash.Core/`
  - `PettyCash.Core.csproj` - core class library project file
  - `Contracts/` - repository and service interface definitions
  - `Models/` - domain model classes
  - `Repositories/` - data access implementations using SQL
  - `Services/` - business logic and validation wrappers
  - `Utilities/` - database helper and initializer

- `PettyCash.WindowsApp/`
  - `PettyCash.WindowsApp.csproj` - Windows Forms application project file
  - `App.config` - application configuration, including SQL Server connection string
  - `Program.cs` - application startup and dependency wiring
  - `Forms/` - modal form definitions for data entry and detail views
  - `Views/` - user controls for main application screens
  - `Properties/` - auto-generated resources and settings

## 10. Forms / Serializers / DTOs
No explicit DTO or serializer classes exist in the project.

### Forms
- `PettyCash.WindowsApp.Forms.AddCash`
  - Linked model: `CashEntry`
  - Fields: amount, date, note
  - Modes: Add / Edit / View
- `PettyCash.WindowsApp.Forms.ExpenseForm`
  - Linked model: `Expense`
  - Fields: title, amount, date, category, description
  - Modes: Add / Edit / View
- `PettyCash.WindowsApp.Forms.CategoryForm`
  - Linked model: `Category`
  - Fields: name, description
  - Modes: Add / Edit / View

### Views
- `PettyCash.WindowsApp.Views.CashView`
  - Shows cash entries grid and filtering controls
- `PettyCash.WindowsApp.Views.ExpenseView`
  - Shows expenses grid, category filter, and search fields
- `PettyCash.WindowsApp.Views.CategoryView`
  - Shows category list and search
- `PettyCash.WindowsApp.Views.DashBoardView`
  - Shows summary cards and charts

## 11. Key Configuration Files
- `PettyCash.WindowsApp/App.config`
  - Contains SQL Server connection string named `PettyCashDB`
  - Provider: `Microsoft.Data.SqlClient`
- `PettyCash.Core/PettyCash.Core.csproj`
  - Defines .NET 10.0 target and package dependency for SQL client
- `PettyCash.WindowsApp/PettyCash.WindowsApp.csproj`
  - Defines Windows Forms .NET 10.0 target and package dependencies for charts and configuration manager

## 12. Third-Party Packages / Dependencies
### `PettyCash.Core`
- `Microsoft.Data.SqlClient` 7.0.1
  - Provides SQL Server client access for ADO.NET

### `PettyCash.WindowsApp`
- `LiveChartsCore.SkiaSharpView.WinForms` 2.0.4
  - Provides WinForms chart controls for dashboard visualization
- `Microsoft.Data.SqlClient` 7.0.1
  - SQL Server client access used by the desktop application
- `System.Configuration.ConfigurationManager` 10.0.8
  - Enables reading `App.config` configuration settings
