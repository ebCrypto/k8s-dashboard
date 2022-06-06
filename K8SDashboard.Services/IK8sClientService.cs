﻿using K8SDashboard.Models;

namespace K8SDashboard.Services
{
    public interface IK8sClientService
    {
        Task<List<LightRoute>> ListLightRoutesWithTimeOut(object defaultNamespace, int retriesLeft);
        
    }
}