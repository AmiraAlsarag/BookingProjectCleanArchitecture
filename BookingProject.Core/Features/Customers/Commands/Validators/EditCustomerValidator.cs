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
	public class EditCustomerValidator:AbstractValidator<EditCustomerCommand>
	{
		#region Fields
		private readonly ICustomerService _customerService;
		#endregion

		#region Constructors
		public EditCustomerValidator(ICustomerService customerService)
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
				.MustAsync(async (model,key, CancellationToken) => !await _customerService.IsNameExistExcludeSelf(key,model.Id))
				.WithMessage("Name Already Exist!");


		}
		#endregion

	}
}
