
<div align="center">
  <h1>📚 Library Management System</h1>
</div>

<p align="center">
  <em>A C# console-based project demonstrating strong OOP principles — manage books, shelves, and card-based sales.</em>
</p>

---

## 📌 Overview

This is a **Library Management System** written in **C#**, built to showcase **object‑oriented programming (OOP)** concepts.  
You can add, remove, search, and display books on shelves, and simulate selling books using different card types (e.g. `OgrenciKart`, `YetiskinKart`) with balance checks.

---

## 🧩 Key Features

- 📂 **Book & Shelf Management**  
  Add books to different shelves, delete them, and list all shelves.

- 🔍 **Search Functionality**  
  Search for books by title.

- 💳 **Card-Based Sales System**  
  Sell books to different card types (Student/Adult), update card balances, and track purchases.

- ✅ **OOP Principles**  
  - **Encapsulation:** Private fields and controlled access.  
  - **Inheritance:** Specialized classes like `OgrenciKart` and `YetiskinKart`.  
  - **Polymorphism:** Overriding methods for flexible behavior.  
  - **Abstraction:** Clean, modular design.

---

## 🚀 How to Run

1️⃣ **Clone the repository**

```bash
git clone https://github.com/yourusername/library-management-system.git
cd library-management-system
```

2️⃣ **Open the project**

- Open `Quiz.csproj` in **Visual Studio** or another C#-compatible IDE.

3️⃣ **Build and Run**

- Press **F5** in Visual Studio **or** use the CLI:
```bash
dotnet build
dotnet run
```

---

## 📄 Example Flow

```
1 ----------------------------------
[Shows all books on all shelves]
2 ----------------------------------
[After deleting a book]
3 ----------------------------------
[Search for a book and display result]
4 ----------------------------------
[Attempt to sell books using YetiskinKart]
[Balance decreases accordingly]
5 ----------------------------------
[Attempt to sell books using OgrenciKart]
```

---

## ✅ Requirements

- .NET SDK (>= .NET 6.0)
- Visual Studio 2022 or Visual Studio Code (C# extension installed)

---

## 💡 Ideas to Improve

- Add a database (e.g. SQLite) to persist data.
- Implement a graphical interface (WPF, WinForms, or MAUI).
- Add user authentication and role-based access.
- Track sales history or generate reports.

---

## 📬 License

This project is free to use, modify, and extend.  
Feel free to fork and create your own version!

---

**Happy coding and enjoy managing your library! 📚✨**
