﻿namespace CleanFullProject.UI.UseCases.CloseAccount
{
    using CleanFullProject.Application;
    using CleanFullProject.Application.UseCases.CloseAccount;
    using Microsoft.AspNetCore.Mvc;

    public class Presenter : IOutputBoundary<CloseOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public CloseOutput Output { get; private set; }

        public void Populate(CloseOutput response)
        {
            Output = response;

            if (response == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            ViewModel = new OkResult();
        }
    }
}