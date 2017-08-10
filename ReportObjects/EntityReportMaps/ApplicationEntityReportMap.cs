﻿using CsvHelper.Configuration;

namespace AppDynamics.OfflineData.ReportObjects
{
    public class ApplicationEntityReportMap: CsvClassMap<EntityApplication>
    {
        public ApplicationEntityReportMap()
        {
            int i = 0;
            Map(m => m.Controller).Index(i); i++;
            Map(m => m.ApplicationName).Index(i); i++;
            Map(m => m.NumTiers).Index(i); i++;
            Map(m => m.NumNodes).Index(i); i++;
            Map(m => m.NumBackends).Index(i); i++;
            Map(m => m.NumBTs).Index(i); i++;
            Map(m => m.NumSEPs).Index(i); i++;
            Map(m => m.NumErrors).Index(i); i++;
            Map(m => m.ApplicationID).Index(i); i++;
            Map(m => m.ControllerLink).Index(i); i++;
            Map(m => m.ApplicationLink).Index(i); i++;
        }
    }
}