﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CvLocate.Common.EndUserDtoInterface.Enums;

namespace CvLocate.Common.EndUserDtoInterface.Query
{
    public class GetRecruiterProfileQuery:BaseRecruiterQuery
    {
        public GetRecruiterProfileQuery(string recruiterId)
            : base(recruiterId)
        {

        }

    }
}
