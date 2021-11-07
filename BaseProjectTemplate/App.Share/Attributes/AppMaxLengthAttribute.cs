﻿using System.ComponentModel.DataAnnotations;

namespace DNews.Shared.Attributes
{
	public class AppMaxLengthAttribute : MaxLengthAttribute
	{
		public AppMaxLengthAttribute():base()
		{
		}

		public AppMaxLengthAttribute(int length) : base(length)
		{
			this.ErrorMessage= $"Không được nhiều hơn {length} ký tự";
		}
	}
}