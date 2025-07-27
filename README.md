🕹️ Game Store Console App — Weekend Challenge
This is a personal project where I challenged myself to explore a new technology — VB.NET with MySQL integration — and see how much I could learn and build in a single weekend, using my existing programming experience and ChatGPT as a learning assistant.

🧩 Problem Statement
I’m building a video game store system that manages three main types of products:
    Consoles
    Games
    Controllers

All products must be registered in the system, and it should support the following operations:
    Add a product
    Remove a product
    Edit product details
    View product information
    Manage product inventory (stock control)

Additionally, customers must be able to:
    Create an account and log in before making a purchase
    Search for products by name
    Add multiple products to their shopping cart

Finalize their purchase by:
    Providing a shipping address
    Selecting a payment method

As a store owner, I must be able to:
    View all purchases made by customers
    Filter purchases by customer


📦 Project Goals
    Practice structured console applications in VB.NET.
    Connect and interact with a MySQL database via MySqlConnector.
    Apply modular programming, separating logic across screens and functional layers.
    Explore user input handling, database validation, and simple screen flows.

✅ What’s been built so far
By the end of the first weekend, I implemented:

🖥️ Console Interface
    Initial database password screen, prompting the user to input the database password, retrying on failure.
    Login screen with input handling for:

    [R] to register a new user (not implemented yet),

    [L] to login (not implemented yet),

    [E] to exit the system gracefully.

🧠 Logic and structure
Modular design using separate modules:
    Program.vb: Main execution flow.
    DbPasswordScreen.vb: Handles the initial DB connection screen.
    SqlConnection.vb: Opens MySQL connection and validates password.
    LoginScreen.vb: Shows the login/register/exit options and captures keyboard input.
    Graceful exit with proper MySQL connection closing and delay before termination.

🛢️ Database setup
The project connects to a MySQL database named gamestore.
Created tables so far: All availables at the folder "DB"

🔜 Next steps
    Implement the user registration flow (triggered by [R]).
    Implement the login authentication (triggered by [L]).
    Add basic game listing and store interaction logic.
    Create validations and error handling for duplicate users and incorrect credentials.
    Possibly migrate to a GUI in the future using WinForms or WPF.

💡 Reflection
    In just one weekend, I was able to:
    Get a working database connection up and running.
    Create interactive and clean console "screens".
    Separate logic in a maintainable, extensible structure.
    Reinforce database fundamentals (PKs, constraints, structure planning).

All of this was done with guidance from ChatGPT, proving how effective AI can be for fast learning and prototyping.