﻿using HCP.FixedAssets.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HCP.FixedAssets.IF
{
    public interface ICommonDataRepository
    {
        Task<List<DO_ApplicationCodes>> GetApplicationCodesByCodeType(int codeType);

        Task<List<DO_ApplicationCodes>> GetApplicationCodesByCodeTypeList(List<int> l_codeType);

        Task<List<DO_DepartmentLocation>> GetDepartmentCodes(int businessKey);

        Task<List<DO_DepartmentLocation>> GetLocationList(int businessKey, int departmentId);

        Task<List<DO_CountryCodes>> GetISDCodes();
    }
}
