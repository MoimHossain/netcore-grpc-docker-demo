

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;

namespace NetcoreConsole.Service
{
    public class AccountsImpl : AccountService.AccountServiceBase
    {
        public override Task<EmployeeName> GetEmployeeName(EmployeeNameRequest request, ServerCallContext context)
        {
            return Task.FromResult(new Data.EmployeeData().GetEmployeeName(request));
        }
    }
}
