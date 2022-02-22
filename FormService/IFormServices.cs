using SparkPlug.WebForm.API.Model;

namespace SparkPlug.WebForm.API.FormService
{
    public interface IFormServices
    {
        bool FormAction(FormSubmissionRequest req);
    }
}