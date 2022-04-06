using AutoMapper;
using leave_management.Contracts;
using leave_management.Data;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using leave_management.Controllers;

namespace Tests.LeaveTypesControllerTests
{
    public class BaseLeaveTypesControllerTests
    {
        protected readonly Mock<ILeaveTypeRepository> _repo;
        private readonly IMapper _mapper;
        protected readonly LeaveTypesController _controllerUnderTest;

        protected BaseLeaveTypesControllerTests()
        {
            _repo = new Mock<ILeaveTypeRepository>();
            _controllerUnderTest = new LeaveTypesController(_repo.Object, _mapper);
        }

    }
}
