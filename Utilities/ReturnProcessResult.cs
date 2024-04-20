using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureDepot.Utilities
{
    /// <summary>
    /// Helper class to process returns and handle displaying errors
    /// </summary>
    public class ReturnProcessResult
    {
        public bool IsSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public int ReturnTransactionID { get; set; }

    }
}
