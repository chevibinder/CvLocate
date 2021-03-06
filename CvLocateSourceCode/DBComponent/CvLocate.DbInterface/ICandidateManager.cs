﻿using CvLocate.Common.EndUserDtoInterface.Command;
using CvLocate.Common.EndUserDtoInterface.DTO;
using CvLocate.Common.EndUserDtoInterface.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvLocate.DbInterface
{
    public interface ICandidateManager
    {
        void SignIn(string email, string password);
        string InsertCandidate(Candidate candidate);
    }
}
