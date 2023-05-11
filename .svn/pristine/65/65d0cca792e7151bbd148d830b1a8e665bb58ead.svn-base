using Microsoft.EntityFrameworkCore;
using HCP.FixedAssets.DL.Entities;
using HCP.FixedAssets.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCP.FixedAssets.IF;

namespace HCP.FixedAssets.DL.Repository
{
    public class CommonDataRepository : ICommonDataRepository
    {
        public static string GetValidationMessageFromException(DbUpdateException ex)
        {
            string msg = ex.InnerException == null ? ex.ToString() : ex.InnerException.Message;

            if (msg.LastIndexOf(',') == msg.Length - 1)
                msg = msg.Remove(msg.LastIndexOf(','));
            return msg;
        }

        public async Task<List<DO_ApplicationCodes>> GetApplicationCodesByCodeType(int codeType)
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var ds = db.GtEcapcd
                        .Where(w => w.CodeType == codeType && w.ActiveStatus)
                        .AsNoTracking()
                        .Select(r => new DO_ApplicationCodes
                        {
                            ApplicationCode = r.ApplicationCode,
                            CodeDesc = r.CodeDesc
                        }).OrderBy(o => o.CodeDesc).ToListAsync();

                    return await ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<DO_ApplicationCodes>> GetApplicationCodesByCodeTypeList(List<int> l_codeType)
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var ds = db.GtEcapcd
                        .Where(w => w.ActiveStatus
                        && l_codeType.Contains(w.CodeType))
                        .AsNoTracking()
                        .Select(r => new DO_ApplicationCodes
                        {
                            CodeType = r.CodeType,
                            ApplicationCode = r.ApplicationCode,
                            CodeDesc = r.CodeDesc
                        }).OrderBy(o => o.CodeDesc).ToListAsync();

                    return await ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<DO_DepartmentLocation>> GetDepartmentCodes(int businessKey)
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var ds = db.GtEadpll
                        .Join(db.GtEadpcd,
                        l => new {l.DepartmentId},
                        c => new {c.DepartmentId},
                        (l,c) => new {l,c})
                        .Where(w => w.l.ActiveStatus && w.l.BusinessKey == businessKey)
                        .AsNoTracking()
                        .Select(r => new DO_DepartmentLocation
                        {
                            DepartmentDesc = r.c.DepartmentDesc,
                            DepartmentID = r.l.DepartmentId
                        }).Distinct().OrderBy(o => o.DepartmentDesc).ToListAsync();

                    return await ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<DO_DepartmentLocation>> GetLocationList(int businessKey, int departmentId)
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var ds = db.GtEadpll
                        .Join(db.GtEadpcd,
                        l => new { l.DepartmentId },
                        c => new { c.DepartmentId },
                        (l, c) => new { l, c })
                        .Where(w => w.l.ActiveStatus && w.l.BusinessKey == businessKey && w.l.DepartmentId == departmentId)
                        .AsNoTracking()
                        .Select(r => new DO_DepartmentLocation
                        {
                            DepartmentDesc = r.c.DepartmentDesc,
                            DepartmentID = r.l.DepartmentId,
                            DeptLocnID = r.l.DeptLocnId,
                            LocationDescription = r.l.LocationDescription,
                            DeptShortDesc = r.c.DeptShortDesc,
                            LocnShortDesc = r.l.LocnShortDesc
                        }).Distinct().OrderBy(o => o.LocationDescription).ToListAsync();

                    return await ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<DO_CountryCodes>> GetISDCodes()
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var ds = db.GtEccncd
                        .Where(w => w.ActiveStatus)
                        .Select(r => new DO_CountryCodes
                        {
                            Isdcode = r.Isdcode,
                            CountryName =r.Isdcode + "-"+ r.CountryName
                        }).ToListAsync();

                    return await ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
