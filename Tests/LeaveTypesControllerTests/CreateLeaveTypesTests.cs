using AutoMapper;
using leave_management.Data;
using leave_management.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace Tests.LeaveTypesControllerTests
{
    public class CreateLeaveTypesTests : BaseLeaveTypesControllerTests
    {
        private static readonly LeaveTypeVM vacation = new LeaveTypeVM() { Id = 1, Name = "Vacation", DateCreated = DateTime.Now };

        public CreateLeaveTypesTests() : base()
        {
        }

        [Fact]
        public void CreateGetShouldHaveNoViewModel()
        {
            var result = _controllerUnderTest.Create();
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewData.Model);
        }

        [Fact]
        public void CreatePostShouldReturnCreateViewModelIfModelIsInvalid()
        {
            _controllerUnderTest.ModelState.AddModelError("", "something went wrong...");
            var result = _controllerUnderTest.Create(vacation);
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.IsAssignableFrom<LeaveTypeVM>(viewResult.ViewData.Model);
        }

    }
}
