////tinfo200:[2021-03-12-<Steven28>-dykstra]
////The model page is esstenial the place where the data (or the classes they are based on) for the page will be stored
/////
using System;

namespace ContosoUniversity.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
