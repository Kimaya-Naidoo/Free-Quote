using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace freeQuote3.Models
{
    public class FreeQuote
    {
        //************contact details******
        [Key]
        public int freeQuote { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Required]
        [Display(Name = "Your Name")]
        public string ConsumerName { get; set; }
        [Required]
        [Display(Name = "Email ")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Phone Number ")]
        public string phoneNumber { get; set; }

        //******shipping info*********
        [Display(Name = "Delivery Date If Required")]
        public DateTime delDate { get; set; }
        [Required]
        [Display(Name = "Equipment Needed ")]
        public string equipment { get; set; }
        [Required]
        [Display(Name = "Quantity ")]
        public string quantity { get; set; }
        [Required]
        [Display(Name = "Type of Cargo ")]
        public string CargoType { get; set; }
        [Required]
        [Display(Name = "Net Average Weight ")]
        public string weight { get; set; }
        [Required]
        [Display(Name = "Dimension (Meters)(L x W x H)")]
        public string dimension { get; set; }
        [Required]
        [Display(Name = "Commodity in Description")]
        public string commodity { get; set; }
        //[Display(Name = "Special Instructions")]
        //public string specInstruct { get; set; }
        [Required]
        [Display(Name = "Collection date ")]
        public DateTime CollectionDate { get; set; }

        //*********calc*********************   
        //public string testtext { get; set; }
        //public double two { get; set; }

        //public string Collection { get; set; }
        //public string Dropoff { get; set; }

        //public double final { get; set; }
        //public string Distance()
        //{
        //    string diss = testtext;
        //    diss = diss.Replace("km", "");
        //    diss = diss.Replace(",", "");
        //    diss = diss.Trim();
        //    return diss;
        //}
        //public string DelStreetNum { get; set; }
        //public string DelStreetName { get; set; }
        //public string DelArea { get; set; }
        //public string DelCity { get; set; }
        //public string DelCode { get; set; }
        //public string ColStreetNum { get; set; }
        //public string ColStreetName { get; set; }
        //public string ColArea { get; set; }
        //public string ColCity { get; set; }
        //public string ColCode { get; set; }

    }


}
