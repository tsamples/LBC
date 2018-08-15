using LBC.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LBC.Services
{
    public interface IDataStore
    {
        Task<AppConfig> GetDataFromAPI();
        AppConfig GetDataFromLocalConfig();
    }
}
