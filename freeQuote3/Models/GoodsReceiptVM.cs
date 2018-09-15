using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace freeQuote3.Models
{
    public class GoodsReceiptVM
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int GoodsID { get; set; }
        [Display(Name = "Date Created")]
        public DateTime dateCreated
        {
            get { return DateTime.Now; }
        }
        [Display(Name = "Special Instructions")]
        public string specInstruct { get; set; }
        [Required]
        [Display(Name = "Net Average Weight ")]
        public string weight { get; set; }
        [Required]
        [Display(Name = "Commodity in Description")]
        public string commodity { get; set; }
        // ****************pick up*********************************

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        //public int BookingIds { get; set; }
        //[Required]
        //[Display(Name = "Street Number")]
        //public string ColStreetNum { get; set; }
        //[Required]
        //[Display(Name = "Street Name")]
        //public string ColStreetName { get; set; }
        //[Required]
        //[Display(Name = "Area")]
        //public string ColArea { get; set; }
        //[Required]
        //[Display(Name = "City")]
        //public string ColCity { get; set; }
        //[Required]
        //[Display(Name = "Postal code")]
        //public string ColCode { get; set; }


        ////****************Delivery*******************************
        //[Required]
        //[Display(Name = "Street Number")]
        //public string DelStreetNum { get; set; }
        //[Required]
        //[Display(Name = "Street Name")]
        //public string DelStreetName { get; set; }
        //[Required]
        //[Display(Name = "Area")]
        //public string DelArea { get; set; }
        //[Required]
        //[Display(Name = "City")]
        //public string DelCity { get; set; }
        //[Required]
        //[Display(Name = "Postal code")]
        //[DataType(DataType.PostalCode)]
        //public string DelCode { get; set; }


        //public string addressDel()
        //{
        //    string ad = "";
        //    ad = DelStreetNum + " " + DelStreetName + " " + DelArea + " " + DelCity + " " + DelCode;
        //    return ad;
        //}
        //public string addressCol()
        //{
        //    string ad = "";
        //    ad = ColStreetNum + " " + ColStreetName + " " + ColArea + " " + ColCity + " " + ColCode;
        //    return ad;
        //}
    }


}