﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CarHub_Web.Models.Dto
{
    public class StateUpdateDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [DisplayName("State Name")]
        public string StateName { get; set; }
        [DisplayName(" Country Name")]

        public int CountryId { get; set; }

        public bool IsActive { get; set; }


    }
}
