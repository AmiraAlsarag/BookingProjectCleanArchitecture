using BookingProject.Core.Features.Customers.Commands.Models;
using BookingProject.Service.Abstracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Features.Customers.Commands.Validators
{
	public class AddCustomerValidator:AbstractValidator<AddCustomerCommand>
	{
		#region Fields
		private readonly ICustomerService _customerService;
		#endregion

		#region Constructors
		public AddCustomerValidator(ICustomerService customerService)
		{
			_customerService = customerService;
			ApplyValidationsRules();
			ApplyCustomValidationsRules();

		}

		#endregion

		#region Actions
		public void ApplyValidationsRules()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Name Must Not Be Empty")
				.NotNull().WithMessage("Name Must Not Be Null!")
				.MaximumLength(15);


		}
		public void ApplyCustomValidationsRules()
		{
			RuleFor(x => x.Name)
				.MustAsync(async (key, CancellationToken) => !await _customerService.IsNameExist(key))
				.WithMessage("Name Already Exist!");


		}
		#endregion

	}
}
