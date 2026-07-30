# 🚗 Vehicle Toll Calculator

A menu-driven C# .NET Console Application that calculates toll charges based on vehicle type, journey type, FASTag availability, and peak hour status. The application demonstrates the fundamentals of Object-Oriented Programming (OOP) by separating data models, business logic, input validation, and user interface into different classes.

## 📌 Features

- Calculate toll charges
- View toll calculation summary
- Clear current input
- Exit the application
- Input validation for all user inputs
- Menu-driven console interface
- Displays transaction date and time on the toll receipt

---

## 🛠️ Technologies Used

- C#
- .NET Console Application
- Object-Oriented Programming (OOP)

---

## 📂 Project Structure

```
VehicleTollCalculator/
│
├── Models/
│   ├── Vehicle.cs
│   └── Toll.cs
│
├── Services/
│   ├── TollCalculator.cs
│   └── InputValidator.cs
│
├── UI/
│   └── Menu.cs
│
└── Program.cs
```

---

## 📖 Business Rules

The toll amount is calculated using the following rules:

### Base Toll Charges

| Vehicle Type | Base Toll |
|--------------|----------:|
| Bike | ₹50 |
| Car | ₹100 |
| Bus | ₹200 |
| Truck | ₹300 |

### Journey Type

- **One Way** → Base Toll
- **Round Trip** → Base Toll × 1.8

### FASTag Discount

- 10% discount on the calculated toll amount

### Peak Hour Charges

- 20% additional charge after applying any FASTag discount

---

## ✔️ Input Validation

The application validates:

- Vehicle number cannot be empty.
- Vehicle type must be:
  - Bike
  - Car
  - Bus
  - Truck
- Journey type must be:
  - One Way
  - Round Trip
- FASTag availability must be:
  - Yes
  - No
- Peak hour input must be:
  - Yes
  - No

Invalid inputs do not terminate the application. The user is prompted until valid input is entered.

---

## ▶️ How to Run

1. Clone the repository.

```bash
git clone https://github.com/your-username/VehicleTollCalculator.git
```

2. Open the project in Visual Studio.

3. Build and run the application.

---

## 📷 Outputs
<details>

<summary><b>Test Case 1 – Viewing Summary Before Calculation</b></summary>
<img src="https://github.com/user-attachments/assets/3215eb77-f18f-4c14-b5ec-b8ec98851df1" width="500"/>
">
<br>
<img src="https://github.com/user-attachments/assets/1c8e50ad-7d9e-4dd8-ab31-0c401c26f780" width="500" />
">

</detials>

<details>

<summary><b>Test Case 1 – Invalid Input Validation</b></summary>
<img src="https://github.com/user-attachments/assets/0dbd3f91-ece8-43a6-b142-ac6e8c7e6999" />
" width="500"/>
">
<br>

</detials>

<details>

<summary><b>Test Case 3 – Successful Toll Calculation</b></summary>
<img src="https://github.com/user-attachments/assets/29151a17-1823-4012-a499-ae97885c300c" />
" width="500"/>
">
<br>
<img src="https://github.com/user-attachments/assets/38398b7b-d93c-4cdc-8a54-63c6b2215def" />
" width="500" />
">

</detials>
---

## 📚 OOP Concepts Demonstrated

- Classes and Objects
- Properties
- Methods
- Object Composition
- Separation of Concerns
- Input Validation
- Switch Statements
- Menu-Driven Console Applications

---

## 🎯 Learning Outcomes

Through this project, I practiced:

- Designing a structured console application in C#
- Applying Object-Oriented Programming principles
- Separating business logic from user interaction
- Implementing input validation
- Working with multiple classes and namespaces
- Using DateTime for transaction logging
- Creating a clean and maintainable project structure

---

## 🚀 Future Improvements

Some enhancements that can be added in future versions include:

- Store toll transactions in a file or database
- Generate printable receipts
- Support additional vehicle categories
- Add multiple toll calculations in a single session
- Validate vehicle registration number format
- Export toll summaries as PDF

---

## 👨‍💻 Author

**Megha S**

B.Tech Computer Science Engineering
