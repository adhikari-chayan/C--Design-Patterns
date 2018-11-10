using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
   public class ExceptionHandler
    {
        private static ExceptionHandler _instance;
        private static readonly object _lock= new object();
        private StreamWriter _streamWriter;

        public static ExceptionHandler Instance
        {
            get
            {
                lock(_lock)
                {
                    if(_instance==null)
                    {
                        _instance = new ExceptionHandler();
                    }
                }
                return _instance;
            }
        }

        private ExceptionHandler()
        {
            string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _streamWriter = new StreamWriter(Path.Combine(exePath, "Exception.log"));
        }

        public void WriteExceptionLog(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss"));
            sb.Append(": ");
            sb.Append(ex.Message);
            _streamWriter.WriteLine(sb.ToString());
            _streamWriter.Flush();
        }
    }
}
