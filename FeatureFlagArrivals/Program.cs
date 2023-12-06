using FeatureFlagArrivals.Classes;
using System;
using FeatureToggle;



namespace FeatureFlagArrivals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Check and use feature flags as before
            if (FeatureFlags.EarthArrivalFeatureEnabled)
            {
                // Earth arrival feature is enabled
                ArriveAtEarth earthMessage = new ArriveAtEarth();
                earthMessage.EarthArrival();
            }

            if (FeatureFlags.MarsArrivalFeatureEnabled)
            {
                // Mars arrival feature is enabled
                ArriveAtMars marsMessage = new ArriveAtMars();
                marsMessage.MarsArrival();
            }

            Console.WriteLine("Press Any key and enter to Exit the Craft.");
            Console.ReadLine();
        }
    }
}

