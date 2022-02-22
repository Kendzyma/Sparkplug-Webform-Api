using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SparkPlug.WebForm.API.Model;
using SparkPlug.WebForm.API.MongoDb;

namespace SparkPlug.WebForm.API.FormService
{
    public class FormServices : IFormServices
    {
        private readonly MongoConnect dbService;

        public FormServices(MongoConnect dbService)
        {
            this.dbService = dbService;
        }
        public bool FormAction(FormSubmissionRequest req)
        {
            var response = false;

            // Creates a collection
            var db = dbService.GetDB(req._formDomainName);

            var collection = db.GetCollection<FormModel>(req._formName);

            try
            {
                var formToInsert = new FormModel
                {
                    CustomerEmail = req.CustomerEmail,
                    CustomerMessage = req.CustomerMessage,
                    CustomerName = req.CustomerName
                };

                // Inserts into db

                collection.InsertOne(formToInsert);

                response = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return response;

        }
    }
}
