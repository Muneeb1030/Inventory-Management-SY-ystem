# Inventory Management System

The Inventory Management System is developed to streamline and automate the process of managing stock, user accounts, sales reports, and receipts. This system ensures efficient handling of inventory-related tasks, providing a user-friendly interface along with robust database functionalities.

## Features
### Stock Management
- **Product Management:**
  - Add New Products
  - Update Product Details
  - Delete Products
- **Stock Control:**
  - Track Stock Levels
  - Stock In and Out Records
  - Low Stock Alerts

### User Management
- **User Accounts:**
  - Create User Accounts
  - Update User Information
  - Delete User Accounts
- **Role Management:**
  - Assign Roles (Admin, Staff)
  - Manage Permissions

### Sale Reports
- **Sales Tracking:**
  - Record Sales Transactions
  - View Daily, Weekly, Monthly Sales
- **Report Generation:**
  - Generate Sales Reports (PDF, Excel)
  - Filter Reports by Date Range, Product, User

### Receipts
- **Receipt Generation:**
  - Generate Receipts for Sales Transactions
  - Print and Email Receipts
- **Receipt History:**
  - View Past Receipts
  - Search Receipts by Date, Product, User

## Problem Statement
Managing inventory manually is cumbersome and error-prone, leading to:
- Inaccurate stock levels
- Inefficient tracking of sales and receipts
- Poor user management and role assignment
- Delayed report generation

## Solution
To address these challenges, we propose an Inventory Management System that:
- Automates stock management
- Enhances accuracy in sales tracking
- Simplifies user management and role assignment
- Provides timely and detailed reports

This system leverages a database management system to efficiently handle all inventory-related tasks, ensuring data accuracy and operational efficiency.

## Tools and Technologies
The Inventory Management System is built using the following technologies:
- **Database:** MySQL Database Server
- **Programming Language:** C#
- **User Interface:** Windows Forms
- **Reporting:** Crystal Reports

## Installation
1. **Clone the Repository:**
   ```sh
   git clone https://github.com/your-repo/inventory-management-system.git
   ```
2. **Setup the Database:**
   - Install MySQL Database Server.
   - Import the provided database schema and data.

3. **Install Dependencies:**
   - Ensure you have .NET Framework installed.
   - Open the solution file in Visual Studio and restore NuGet packages.

4. **Build and Run the Application:**
   - Build the project in Visual Studio.
   - Run the application.

## Usage
1. **Admin Login:**
   - Use admin credentials to access the admin module.
   - Manage stock, users, sales reports, and receipts.

2. **User Login:**
   - Use user credentials to access stock management and sales modules based on assigned roles.

3. **Reports and Receipts:**
   - Generate and view sales reports.
   - Generate, print, and email sales receipts.
