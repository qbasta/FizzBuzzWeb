using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
	public class moduloCheck : ValidationAttribute
	{

		private int firstDiv, secondDiv;
		public moduloCheck(int firstDivider, int secondDivider)
		{
			this.firstDiv = firstDivider;
			this.secondDiv = secondDivider;
		}
		public override bool IsValid(object? value)
		{
			if (value == null)
			{
				return true;
			}
			int number = (int)value;

			if (number % firstDiv == 0 && number % secondDiv == 0)
			{
				ErrorMessage  = "FizzBuzz";
				return false;
			}
			if (number % firstDiv == 0)
			{
				ErrorMessage = "Fizz";
				return false;
			}
			if (number % secondDiv == 0)
			{
				ErrorMessage = "Buzz";
				return false;
			}
			ErrorMessage = "liczba: " + number + " nie spelnia kryteriow FizzBuzz ";
			return false;
		}


	}
}

