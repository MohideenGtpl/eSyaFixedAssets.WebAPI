﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HCP.FixedAssets.DO;

namespace HCP.FixedAssets.IF
{
    public interface IAssetGroupRepository
    {
        #region Asset Group
        Task<List<DO_AssetGroup>> GetAssetGroupTreeView();

        Task<DO_AssetGroup> GetAssetGroupbyId(int AssetgroupId, int AssetsubgroupId);

        Task<DO_ReturnParameter> InsertOrUpdateAssetGroup(DO_AssetGroup obj);

        #endregion Asset Group

        #region Depreciation Method
        Task<DO_ReturnParameter> InsertDepreciationMethod(List<DO_AssetDepreciationMethod> obj);

        Task<DO_ReturnParameter> UpdateDepreciationMethod(DO_AssetDepreciationMethod obj);

        List<DO_AssetDepreciationMethod> GetAssetDepreciationMethodsbyAssGroupId(int assetGroupId, int assetSubGroupId, int Isdcode);

        Task<List<DO_AssetGroup>> GetAssetGroupforGrid(int AssetId, int Isdcode);
        #endregion Depreciation Method
    }
}
