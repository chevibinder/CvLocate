﻿using CvLocate.Common.EndUserDtoInterface.Command;
using CvLocate.Common.EndUserDtoInterface.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvLocate.Common.DbFacadeInterface
{
    public interface IUserDBFacade
    {
        SignResponse SignUp(SignUpCommand command);
        SignResponse SignIn(SigninCommand command);
    }
}
