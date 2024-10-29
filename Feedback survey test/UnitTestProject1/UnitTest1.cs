using System;
using Feedback_survey_test;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateFeedback_EmptyFields_ReturnsErrors()
        {
            // Arrange
            var feedbackForm = new FeedbackForm();
            var feedback = new Feedback
            {
                Name = string.Empty,
                Email = string.Empty,
                FeedbackContent = string.Empty
            };

            // Act
            var result = feedbackForm.ValidateFeedback(feedback);

            // Assert
            var expectedErrors = new List<string>
            {
                "Name is required.",
                "Email is required.",
                "Feedback is required."
            };

            CollectionAssert.AreEqual(expectedErrors, result);
        }

        [TestMethod]
        public void ValidateFeedback_PartiallyFilledFields_ReturnsErrors()
        {
            // Arrange
            var feedbackForm = new FeedbackForm();
            var feedback = new Feedback
            {
                Name = "John Doe",
                Email = string.Empty,
                FeedbackContent = "Great service!"
            };

            // Act
            var result = feedbackForm.ValidateFeedback(feedback);

            // Assert
            var expectedErrors = new List<string>
            {
                "Email is required."
            };

            CollectionAssert.AreEqual(expectedErrors, result);
        }

        [TestMethod]
        public void ValidateFeedback_AllFieldsFilled_ReturnsNoErrors()
        {
            // Arrange
            var feedbackForm = new FeedbackForm();
            var feedback = new Feedback
            {
                Name = "John Doe",
                Email = "john@example.com",
                FeedbackContent = "Great service!"
            };

            // Act
            var result = feedbackForm.ValidateFeedback(feedback);

            // Assert
            Assert.AreEqual(0, result.Count);
        }
    }
}
