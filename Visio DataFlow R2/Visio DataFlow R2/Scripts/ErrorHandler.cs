using System;
using System.Windows.Forms;
using log4net;
using log4net.Config;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Visio_DataFlow_R2.Scripts
{
    /// <summary> 
    /// Used to handle exceptions
    /// </summary>
    public class ErrorHandler
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ErrorHandler));

        /// <summary>
        /// Create a log record to track which methods are being used.
        /// </summary>
        public static void CreateLogRecord()
        {
            try
            {
                System.Diagnostics.StackFrame sf = new System.Diagnostics.StackFrame(1);
                System.Reflection.MethodBase caller = sf.GetMethod();
                string currentProcedure = (caller.Name).Trim();
                log.Info("[PROCEDURE]=|" + currentProcedure );
                //log.Info("[PROCEDURE]=|" + currentProcedure + "|[USER NAME]=|" + Environment.UserName + "|[MACHINE NAME]=|" + Environment.MachineName);
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayMessage(ex);

            }
        }

        /// <summary> 
        /// Used to produce an error message
        /// <example>
        /// <code lang="C#">
        /// ErrorHandler.DisplayMessage(ex);
        /// </code>
        /// </example> 
        /// </summary>
        /// <param name="ex">Represents errors that occur during application execution.</param>
        /// <remarks></remarks>
        public static void DisplayMessage(Exception ex)
        {
            System.Diagnostics.StackFrame sf = new System.Diagnostics.StackFrame(1);
            System.Reflection.MethodBase caller = sf.GetMethod();
            string currentProcedure = (caller.Name).Trim();
            string errorMessageDescription = ex.ToString();
            errorMessageDescription = System.Text.RegularExpressions.Regex.Replace(errorMessageDescription, @"\r\n+", " "); 
            string msg = "Contact your system administrator. A record has been created in the log file." + Environment.NewLine;
            msg += "Procedure: " + currentProcedure + Environment.NewLine;
            msg += "Description: " + ex.ToString() + Environment.NewLine;
            MessageBox.Show(msg, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            log.Error("[PROCEDURE]=|" + currentProcedure + "|[DESCRIPTION]=|" + errorMessageDescription);
            //log.Error("[PROCEDURE]=|" + currentProcedure + "|[USER NAME]=|" + Environment.UserName + "|[MACHINE NAME]=|" + Environment.MachineName + "|[DESCRIPTION]=|" + errorMessageDescription);
        }

    }
}