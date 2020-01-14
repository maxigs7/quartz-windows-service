using System;

namespace Quartz.Service.Server
{
    /// <summary>
    /// Factory class to create Quartz server implementations from.
    /// </summary>
    public class QuartzServerFactory
    {
        /// <summary>
        /// Creates a new instance of an Quartz.NET server core.
        /// </summary>
        /// <returns></returns>
        public static QuartzServer CreateServer()
        {
            string typeName = Configuration.ServerImplementationType;

            Type t = Type.GetType(typeName, true);

            // TODO: Add Log.Debug("Creating new instance of server type '" + typeName + "'");
            QuartzServer retValue = (QuartzServer)Activator.CreateInstance(t);
            // TODO: Add Log.Debug("Instance successfully created");
            return retValue;
        }
    }
}
