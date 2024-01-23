Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](BlogTracking/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

Feature: Blog Tracking
    Simple blog tracking system to manage admins, employees, and blogs.

    @mytag
    Scenario: Admin Authentication
        Given there is an admin with email 'admin@example.com' and password 'admin'
        When the admin is authenticated
        Then the admin should be validated successfully

    @mytag
    Scenario: Employee Information
        Given there is an employee with email 'rama@gmail.com', name 'Soum', joining date '2023-09-21', and passcode '4321'
        When the employee information is saved
        Then the employee should be successfully added to the database

    @mytag
    Scenario: Blog Information
        Given there is a blog with title 'Todays Blog', subject 'Developing', creation date '2021-01-15', URL 'http://todaysblog.com', and associated employee email 'soum@gmail.com'
        When the blog information is saved
        Then the blog should be successfully added to the database

        When all blog information is retrieved
        Then the total number of blogs should be greater than 0


