namespace BigSchool1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string LectureId { get; set; }

       // [Required]
        [StringLength(255)]
        [Required(ErrorMessage = "Khong duoc de trong: ")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        public string Place { get; set; }
        [Required(ErrorMessage = "Khong duoc de trong: ")]
        public DateTime DateTime { get; set; }
        [Required(ErrorMessage = "Khong duoc de trong: ")]
        public int CategoryId { get; set; }
        
        public virtual Category Category { get; set; }
      // public string Name { get; set; }

        //add list category
        public List<Category> ListCategory = new List<Category>();
    }
}
