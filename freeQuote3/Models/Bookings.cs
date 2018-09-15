using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace freeQuote3.Models
{
    public class Bookings
    {
        // ****************pick up*********************************
           
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
             [Key]
        public int BookingIds { get; set; }
            [Required]
            [Display(Name = "Street Number")]
            public string ColStreetNum { get; set; }
            [Required]
            [Display(Name = "Street Name")]
            public string ColStreetName { get; set; }
            [Required]
            [Display(Name = "Area")]
            public string ColArea { get; set; }
            [Required]
            [Display(Name = "City")]
            public string ColCity { get; set; }
            [Required]
            [Display(Name = "Postal code")]
            public string ColCode { get; set; }
            [Required]
            [Display(Name = "Date")]
            //  [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
            public DateTime? pickupdate { get; set; }


            //****************Delivery*******************************
            [Required]
            [Display(Name = "Street Number")]
            public string DelStreetNum { get; set; }
            [Required]
            [Display(Name = "Street Name")]
            public string DelStreetName { get; set; }
            [Required]
            [Display(Name = "Area")]
            public string DelArea { get; set; }
            [Required]
            [Display(Name = "City")]
            public string DelCity { get; set; }
            [Required]
            [Display(Name = "Postal code")]
            [DataType(DataType.PostalCode)]
            public string DelCode { get; set; }
            [Required]
            [Display(Name = "Drop off Date")]
            //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
            public DateTime dropofdate { get; set; }


            //********************Booking Details******************
            [Required]
            [Display(Name = "Client Name")]
            public string clientname { get; set; }
            [Required]
            [Display(Name = "Contact Number")]
            public string cellnum { get; set; }
            [Required]
            [Display(Name = "Email Address")]
            [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
            public string email { get; set; }
            [Display(Name = "Special Instructions")]
            public string specInstruct { get; set; }
            public Boolean Assigned { get; set; }

            //no validation for this
            public string delcon { get; set; }
            public string colcon { get; set; }

            public string addressDel()
            {
                string ad = "";
                ad = DelStreetNum + " " + DelStreetName + " " + DelArea + " " + DelCity + " " + DelCode;
                return ad;
            }
            public string addressCol()
            {
                string ad = "";
                ad = ColStreetNum + " " + ColStreetName + " " + ColArea + " " + ColCity + " " + ColCode;
                return ad;
            }
        public virtual List <FreeQuote> freeQuotes { get; set; }
        public int freeQuote { get; set; }

    }
    }
