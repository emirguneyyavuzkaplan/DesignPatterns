using MediatorPattern.Lab2.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab2.Abstract
{
    public abstract class AssignedCourseMember
    {
        private readonly CoreMediator coreMediator;

        public AssignedCourseMember(CoreMediator coreMediator)
        {
            this.coreMediator = coreMediator;
        }
    }
}
