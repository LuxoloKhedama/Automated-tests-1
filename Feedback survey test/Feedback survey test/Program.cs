using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_survey_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var feedbackForm = new FeedbackForm();
            var feedback = new Feedback();

            Console.WriteLine("Welcome to the Feedback Form!");
            Console.WriteLine("Please fill out the form below.");

            // Collect Name
            while (string.IsNullOrWhiteSpace(feedback.Name))
            {
                Console.Write("Name (required): ");
                feedback.Name = Console.ReadLine();
            }

            // Collect Email
            while (string.IsNullOrWhiteSpace(feedback.Email))
            {
                Console.Write("Email (required): ");
                feedback.Email = Console.ReadLine();
            }

            // Collect Feedback
            while (string.IsNullOrWhiteSpace(feedback.FeedbackContent))
            {
                Console.Write("Feedback (required): ");
                feedback.FeedbackContent = Console.ReadLine();
            }

            // Validate Feedback
            var errors = feedbackForm.ValidateFeedback(feedback);
            if (errors.Count > 0)
            {
                Console.WriteLine("\nPlease correct the following errors:");
                foreach (var error in errors)
                {
                    Console.WriteLine(error);
                }
            }
            else
            {
                // Display Confirmation
                Console.WriteLine("\nThank you for your feedback!");
                Console.WriteLine("Name: {feedback.Name}");
                Console.WriteLine("Email: {feedback.Email}");
                Console.WriteLine("Feedback: {feedback.FeedbackContent}");
            }

            // Pause before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        }
    }

