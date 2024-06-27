/*
 * FlexiCapture script objects are stored in the ControllerInterop.dll and ShellInterop.dll assemblies 
 * and belong to the ABBYY.FlexiCapture and ABBYY.FlexiCapture.ClientUI namespaces, accordingly. 
 * The assemblies are located in the root folder of the program.
 * 
 */


extern alias aControllerInterlop;
using aControllerInterlop::ABBYY.FlexiCapture;
using System;
using System.Windows;

namespace AbbyyDataExport
{
    public class BaseClass
    {
        protected IBatch _batch;

        public BaseClass(IBatch batch) { 
        
            if (batch == null)
            {
                MessageBox.Show("Error Null assembly reference for IBatch");
            }

            _batch = batch;     
        }

        public void ShowMessage(string text)
        {
            //MessageBox.Show("Hello World");

            FCTools.ShowMessage(text, false);
        }

        public void ShowBatchName(IBatch batch)
        {
            FCTools.ShowMessage(batch.Name, false);
        }

        public void Execute()
        {            
            try
            {
                string nameBatch = _batch.Name;
                int idBatch = _batch.Id;
                string batchType = _batch.BatchTypeName;

                string nameUser = "Empty User";
                if (_batch.CreatedBy != null)
                    nameUser = _batch.CreatedBy.Name;

                DateTime dateCreated = DateTime.MinValue;
                if (_batch.CreationDate != null)
                    dateCreated = (DateTime)_batch.CreationDate;

                int countDocuments = _batch.Documents.Count;

                string message = string.Format("Batch Type: {0}; Username: {1}; Batch Created Date: {2}; Batch Name: {3}; Batch Id: {4}; Documents in batch: {5}", batchType, nameUser, dateCreated, nameBatch, idBatch, countDocuments);
                FCTools.ShowMessage(message, false);
                
            }
            catch (Exception ex)
            {
                //CommonBatchProperties.FromBatch(batch).BatchComment.Value = ex.Message;
                //Handler.ReportException(ex, processingCallback, batch, (object)executor);

                FCTools.ShowMessage(ex.Message, false);
            }
        }
    }
}