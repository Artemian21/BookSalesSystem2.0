# Book Sales System 2.0

A comprehensive desktop application for managing book sales, inventory, orders, and user authentication.

## Project Overview

BookSalesSystem 2.0 is a Windows Forms application built with .NET 8, designed to provide a complete solution for bookstore management. The system handles book inventory, customer orders, user authentication, and sales tracking.

## Features

- **User Authentication System**
  - Secure login and registration
  - Password encryption and validation
  - User role management
  - Email validation

- **Book Management**
  - Complete book inventory tracking
  - ISBN validation
  - Stock level monitoring
  - Book categorization by genre
  - Price management

- **Order Processing**
  - Customer order management
  - Order status tracking
  - Payment status monitoring
  - Detailed order history
  - Multiple items per order support

- **Customer Management**
  - Customer profile management
  - Contact information tracking
  - Order history per customer
  - Email and phone validation

## Technology Stack

- **Framework:** .NET 8.0
- **Language:** C# 12.0
- **UI Framework:** Windows Forms
- **Database:** Entity Framework Core
- **Data Validation:** System.ComponentModel.DataAnnotations
- **Architecture:** Object-Oriented Programming with Domain-Driven Design principles

## Project Structure

```
BookSalesSystem2.0/
├── BookFolder/
│   ├── Book.cs                 # Book entity model
│   └── [Book-related services] # Book management logic
│
├── OrderFolder/
│   ├── Order.cs               # Order entity model
│   ├── OrderItem.cs           # Order item entity model
│   └── [Order services]       # Order processing logic
│
├── UserFolder/
│   ├── User.cs               # User entity model
│   ├── ValidateUserInput.cs  # User input validation
│   └── [User services]       # User management logic
│
├── Data/
│   └── BookSalesSystemContext.cs  # EF Core DbContext
│
└── Program.cs                 # Application entry point
```

## Key Components

### Book Entity
- Manages book information including:
  - Title, Author, Genre
  - ISBN (13-digit validation)
  - Price and stock management
  - Input validation for all fields

### Order System
- Comprehensive order processing:
  - Customer details
  - Multiple books per order
  - Total price calculation
  - Order status tracking
  - Payment status monitoring

### User Management
- Robust user authentication:
  - Email validation
  - Password complexity requirements
  - User profile management
  - Input validation and error handling

## Data Validation

The system implements comprehensive validation using Data Annotations:
- Required field validation
- String length restrictions
- Email format validation
- Phone number format validation
- Price and quantity range validation
- ISBN format validation

## Database

The application uses Entity Framework Core for:
- Automatic migrations
- Data context management
- Entity relationships
- CRUD operations

## Security Features

- Password complexity requirements
- Input validation and sanitization
- Error handling and logging
- User authentication and authorization

## Requirements

- Windows Operating System
- .NET 8.0 Runtime
- Database Server (configured in connection string)

## Setup and Installation

1. Clone the repository
2. Ensure .NET 8.0 SDK is installed
3. Update the database connection string if needed
4. Run database migrations
5. Build and run the application

## Development

To set up the development environment:

1. Install Visual Studio 2022 or later
2. Install .NET 8.0 SDK
3. Clone the repository
4. Open the solution file
5. Restore NuGet packages
6. Run the application

## Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request
