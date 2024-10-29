using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_survey_test
{
    public class FeedbackForm
    {
        public List<string> ValidateFeedback(Feedback feedback)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(feedback.Name))
            {
                errors.Add("Name is required.");
            }

            if (string.IsNullOrWhiteSpace(feedback.Email))
            {
                errors.Add("Email is required.");
            }

            if (string.IsNullOrWhiteSpace(feedback.FeedbackContent))
            {
                errors.Add("Feedback is required.");
            }

            return errors;
        }
    }
}
