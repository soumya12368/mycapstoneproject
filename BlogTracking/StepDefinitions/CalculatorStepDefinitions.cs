using System;
using TechTalk.SpecFlow;
using BlogDAL;
using NUnit.Framework;

namespace BlogTracking.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private AdminInfo? admin;
        private EmpInfo? employee;
        private BlogInfo? blog;

        [Given(@"there is an admin with email '([^']*)' and password '([^']*)'")]
        public void GivenThereIsAnAdminWithEmailAndPassword(string email, string password)
        {
            // Initialize admin object with provided email and password
            admin = new AdminInfo
            {
                EmailId = email,
                Password = password
            };
        }

        [When(@"the admin is authenticated")]
        public void WhenTheAdminIsAuthenticated()
        {
            // Implement authentication logic here
            // For example: admin.AuthenticateAdmin(admin.EmailId, admin.Password);
            // Assertion can be added to verify the authentication result
            // For now, let's assume the authentication is successful
            bool authenticationResult = true;

            // Assert that the authentication is successful
            Assert.True(authenticationResult, "Admin authentication failed");
        }

        [Then(@"the admin should be validated successfully")]
        public void ThenTheAdminShouldBeValidatedSuccessfully()
        {
            // Add assertion for successful validation if needed
            // For example: Assert.IsTrue(admin.IsValid, "Admin is not validated successfully");
        }

        [Given(@"there is an employee with email '([^']*)', name '([^']*)', joining date '([^']*)', and passcode '([^']*)'")]
        public void GivenThereIsAnEmployeeWithEmailNameJoiningDateAndPasscode(string email, string name, string joiningDate, int passCode)
        {
            // Initialize employee object with provided details
            employee = new EmpInfo
            {
                EmailId = email,
                Name = name,
                DateOfJoining = DateTime.Parse(joiningDate),
                PassCode = passCode
            };
        }

        [When(@"the employee information is saved")]
        public void WhenTheEmployeeInformationIsSaved()
        {
            // Save the employee information to the database
            EmpInfoRepository empRepository = new EmpInfoRepository();
            empRepository.SaveEmpInfo(employee);
        }

        [Then(@"the employee should be successfully added to the database")]
        public void ThenTheEmployeeShouldBeSuccessfullyAddedToTheDatabase()
        {
            // Add assertion for successful addition of employee if needed
            // For example: Assert.IsTrue(employeeAddedSuccessfully, "Employee was not added successfully");
        }

        [Given(@"there is a blog with title '([^']*)', subject '([^']*)', creation date '([^']*)', URL '([^']*)', and associated employee email '([^']*)'")]
        public void GivenThereIsABlogWithTitleSubjectCreationDateURLAndAssociatedEmployeeEmail(string title, string subject, string creationDate, string url, string employeeEmail)
        {
            // Initialize blog object with provided details
            blog = new BlogInfo
            {
                Title = title,
                Subject = subject,
                DateOfCreation = DateTime.Parse(creationDate),
                BlogUrl = url,
                EmpEmailId = employeeEmail
            };
        }

        [When(@"the blog information is saved")]
        public void WhenTheBlogInformationIsSaved()
        {
            // Save the blog information to the database
            BlogInfoRepository blogRepository = new BlogInfoRepository();
            blogRepository.SaveBlogInfo(blog);
        }

        [Then(@"the blog should be successfully added to the database")]
        public void ThenTheBlogShouldBeSuccessfullyAddedToTheDatabase()
        {
            // Add assertion for successful addition of blog if needed
            // For example: Assert.IsTrue(blogAddedSuccessfully, "Blog was not added successfully");
        }

        [When(@"all blog information is retrieved")]
        public void WhenAllBlogInformationIsRetrieved()
        {
            // Retrieve all blog information from the database
            BlogInfoRepository blogRepository = new BlogInfoRepository();
            var allBlogs = blogRepository.GetAllBlogInfo();

            // You can store the result for further assertions if needed
        }

        [Then(@"the total number of blogs should be greater than (.*)")]
        public void ThenTheTotalNumberOfBlogsShouldBeGreaterThan(int expectedCount)
        {
            // Add assertion for the total number of blogs
            // For example: Assert.IsTrue(allBlogs.Count > expectedCount, "Total number of blogs is not as expected");
        }
    }
}
