using System;

namespace design_patters.Facade
{
    public interface StatisticsService
    {
        void SaveStatistics(AdRequest adRequest, User user, DateTime date);
    }
}
