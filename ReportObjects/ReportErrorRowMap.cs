﻿using CsvHelper.Configuration;

namespace AppDynamics.OfflineData.ReportObjects
{
    public class ReportErrorRowMap : CsvClassMap<ReportErrorRow>
    {
        public ReportErrorRowMap()
        {
            int i = 0;
            Map(m => m.Controller).Index(i); i++;
            Map(m => m.ApplicationName).Index(i); i++;
            Map(m => m.ApplicationID).Index(i); i++;
            Map(m => m.ErrorName).Index(i); i++;
            Map(m => m.ErrorType).Index(i); i++;
            Map(m => m.HttpCode).Index(i); i++;
            Map(m => m.ErrorDepth).Index(i); i++;
            Map(m => m.ErrorLevel1).Index(i); i++;
            Map(m => m.ErrorLevel2).Index(i); i++;
            Map(m => m.ErrorLevel3).Index(i); i++;
            Map(m => m.ErrorLevel4).Index(i); i++;
            Map(m => m.ErrorLevel5).Index(i); i++;
            Map(m => m.TierName).Index(i); i++;
            Map(m => m.TierID).Index(i); i++;
        }
    }
}
