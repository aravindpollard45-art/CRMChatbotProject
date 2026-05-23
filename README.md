# CRM Chatbot Project

## Overview

CRM Chatbot is a full-stack customer service management system built using ASP.NET Core Web API and React.

This project allows users to:

- Register and Login
- Add Vehicles
- Book Services
- View Bookings
- Submit Complaints
- Chat with Chatbot
- Admin Management

---

# Tech Stack

## Backend
- ASP.NET Core Web API
- C#
- Entity Framework Core
- SQL Server
- JWT Authentication
- BCrypt Password Hashing

## Frontend
- React
- Axios
- React Router DOM

---

# Features

## Authentication
- User Registration
- User Login
- JWT Token Authentication
- Role-based Authorization
- Password Hashing using BCrypt

## Vehicle Module
- Add Vehicle
- View User Vehicles

## Booking Module
- Book Vehicle Service
- View My Bookings

## Complaint Module
- Create Complaint

## Chatbot Module
- Customer Support Chatbot

## Admin Module
- View All Bookings
- Manage System Data

---

# Architecture

- API Layer
- Application Layer
- Domain Layer
- Infrastructure Layer

---

# Security

- JWT Authentication
- Protected Routes
- Password Hashing
- Role Authorization

---

# How to Run Backend

```bash
dotnet restore
dotnet ef database update
dotnet run
```

Backend URL:

```text
https://localhost:7011
```

---

# How to Run Frontend

```bash
npm install
npm run dev
```

Frontend URL:

```text
http://localhost:5173
```

---

# Future Improvements

- Payment Integration
- Email Notifications
- File Upload
- Docker Deployment
- Cloud Hosting
- Responsive UI

---

# Author

Aravind