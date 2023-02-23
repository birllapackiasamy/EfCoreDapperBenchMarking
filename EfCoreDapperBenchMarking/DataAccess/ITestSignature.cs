using System;
using System.Collections.Generic;
using System.Text;

namespace DapperEFCorePerformanceBenchmarks.DataAccess
{
    public interface ITestSignature
    {
        long GetPlayerByID(int id);
        long GetTeamByID(int teamID);
        long GetTeamForSportByIdAsync(int sportID);
    }
}
