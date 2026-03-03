🚀 ZenOSBE Setup Guide

This guide will help you set up and run the ZenOSBE project on your local machine.

📦 Requirements

Before starting, make sure you have installed:

🟪 .NET 10 SDK
💻 Visual Studio 2026 (ensure it supports .NET 10)
🗄️ Microsoft SQL Server 2022

🛢️ Database Scripts

This folder contains SQL scripts used for creating and initializing the ZenOS database.

📂 Files

📜 ZenOS.Database → InitialSchema.sql → Combined script for quick setup.

⚡ How to Use

🖥️ Open SQL Server Management Studio (SSMS) or Azure Data Studio.

▶️ Run the InitialSchema.sql file to create and initialize the database.

🔧 Update the connection string in appsettings.json of your API project:

Location:

ZenOS.API/appsettings.json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=ZenOS;User Id=YOUR_USER;Password=YOUR_PASSWORD;"
}

Replace:

YOUR_SERVER → Your SQL Server instance

YOUR_USER → Database username

YOUR_PASSWORD → Database password

🔑 API Settings

In your ZenOS.API project appsettings.json, configure authentication and mail settings:

"Tokens": {
  "Key": "your-secret-key",
  "Issuer": "ZenOS"
},
"ConfigMail": {
  "SMTPHost": "smtp.gmail.com",
  "SMTPPort": 587,
  "FromEmail": "youremail@gmail.com",
  "EmailPassword": "your-app-password",
  "FromName": "ZenOS System"
}

Key → Secret key for JWT authentication (keep it secure).
Issuer → Can be your name, company, or system name.
SMTP settings → Required if you want the system to send emails (e.g., password reset, notifications). Use an app-specific password for Gmail.

🌐 API Configuration

Ensure your API runs correctly by checking:

ZenOS.API/Properties/launchSettings.json

Example:

https://localhost:5001

Adjust the port if necessary.

▶️ Running the Project

1️⃣ Open ZenOSBE.sln in Visual Studio 2026.
2️⃣ Set ZenOS.API as the Startup Project.
3️⃣ Press F5 or click Run.

Swagger should open automatically (if enabled).

✅ After completing these steps, your ZenOSBE should be ready to run locally! 🚀
