using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class SearchInputModel
    {
        public int CustId { get; set; }
        [Display(Name = "Customer")]
        public string Customer { get; set; }
        [Display(Name = "Machine Name")]
        public string MachineName { get; set; }
        [Display(Name = "Supplier")]
        public int? SupplierId { get; set; }
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }
        public string PartNumber { get; set; }
        [Display(Name = "WC Trigger Limit")]
        public Boolean CustomLimit { get; set; }
        public string Location { get; set; }
        [Display(Name = "Date From")]
        public DateTime DateFrom { get; set; }
        [Display(Name = "Date To")]
        public DateTime DateTo { get; set; }

        //[Required(ErrorMessage = "Please select file")]
        //[Display(Name = "File")]
        //[DataType(DataType.Upload)]
        //[AllowedExtensions(new string[] {  ".xlsx", ".csv" })]
        //public IFormFile File { get; set; }
    }
}
