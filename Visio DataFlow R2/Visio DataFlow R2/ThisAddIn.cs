using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Visio = Microsoft.Office.Interop.Visio;
using Office = Microsoft.Office.Core;
using Visio_DataFlow_R2.Scripts;

namespace Visio_DataFlow_R2
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
                ErrorHandler.CreateLogRecord();
            try
            {
                Globals.ThisAddIn.Application.MarkerEvent += new Visio.EApplication_MarkerEventEventHandler(Application_MarkerEvent);
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayMessage(ex);
            }
        }

        private void Application_MarkerEvent(Visio.Application visapp, int SequenceNum, string ContextString)
        {
                ErrorHandler.CreateLogRecord();
            try
            {
                if (ContextString.Contains("soln=APDataFlow") && ContextString.Contains("/cmd=DocCreated") && (visapp.ActiveDocument.Keywords == "APDataFlow"))
                {
                    SetDocEvents();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayMessage(ex);
            }

        }

        public void SetDocEvents()
        {
            ErrorHandler.CreateLogRecord();
            Microsoft.Office.Interop.Visio.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            try
            {
                doc.ShapeAdded += new Microsoft.Office.Interop.Visio.EDocument_ShapeAddedEventHandler(OnShapeAdded);
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.WriteLine(err.Message);
                throw;
            }
        }

        private void OnShapeAdded(Visio.Shape Shape)
        {
            ErrorHandler.CreateLogRecord();
            try
            {
                Form_Entity fe = new Form_Entity(Shape.Text);
                fe.ShowDialog();
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayMessage(ex);
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            ErrorHandler.CreateLogRecord();
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
