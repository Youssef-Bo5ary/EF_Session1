using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Session1.Entities
{
   //EFCore Supports 4 ways for mapping classes to DB (Tables | View)
     //  1. By Convention ( Default Behavior)
    
    //entity in DB // entity Domain Model , Model
    // POCO Class => ( Plain  Old CLR Object)
    internal class Employee
    {

        public int EmpID { get; set; }
        
        public string? Name { get; set; }

        public decimal Salary { get; set; }

        public int Age { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }


        //Data Annotation (set of attributes)
        #region Data Annotation
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        //public int EmpID { get; set; }
        //[Required]
        //[Column(TypeName = "Varchar")]
        //[StringLength(50, MinimumLength = 10)]
        //public string? Name { get; set; }

        //[DataType(DataType.Currency)]

        //public decimal Salary { get; set; }

        //[Range(22, 60)]

        //public int Age { get; set; }

        ////[DataType(DataType.EmailAddress)]
        //[EmailAddress]
        //public string Email { get; set; }

        //[Phone]
        //public string PhoneNumber { get; set; }

        //[DataType(DataType.Password)]
        //public string Password { get; set; }
        #endregion


        // 1st way of Mapping ==== BY CONVENTION =============
        #region BY CONVENTION 
        //public int ID { get; set; }// make PK and put for it [identity constraint (1,1)]
        //public string? Name { get; set; }//reference type : allow null in .net 5.0
        //                              // reference type : not allow null in .net 6.0
        //                              //nvarchar (Max) its type in DB by convention

        //public decimal Salary { get; set; }//decimal (18,2) 18 digits and 2 digits after point

        //public int Age { get; set; }//Int 
        #endregion
    }
}
