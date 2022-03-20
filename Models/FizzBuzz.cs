using System;
using System.ComponentModel.DataAnnotations;
using FizzBuzzWeb.Models;
namespace FizzBuzzWeb.Models
{
	public class FizzBuzz
	{
		[Display(Name = "Twoj szczesliwy numerek")]
		[Required]
		[Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
		[moduloCheck(firstDivider: 3, secondDivider: 5)]
		public int? Number { get; set; }
		public FizzBuzz()
		{
			Number = null;
		}
		public bool numberExists()
		{
			if (Number != null)
			{
				return true;
			}
			return false;
		}


	}
}