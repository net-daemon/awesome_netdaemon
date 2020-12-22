using NetDaemon.Common.Reactive;
using Database.Db;
using System.Linq;
// using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;
using System;

namespace PersistentApp
{
    /// <summary>
    ///     Baseclass that has persistent storage capability
    /// </summary>
    public class PersistentStateAppBase : NetDaemonRxApp
    {
        public string? ConnectionString { get; set; } = null;

        /// <summary>
        ///     Get persistent state
        /// </summary>
        /// <param name="name">Name of state</param>
        public object? GetPersistentState(string name)
        {
            _ = ConnectionString ??
                throw new NullReferenceException("Connection string cannot be null, please set");

            using (var c = new StateDbContext(ConnectionString))
            {
                var prop = c.States.FirstOrDefault(n => n.PropName == name);

                if (prop is null)
                    return null;

                if (prop.IntValue is not null)
                    return prop.IntValue;
                else if (prop.DoubleValue is not null)
                    return prop.DoubleValue;
                else if (prop.StringValue is not null)
                    return prop.StringValue;
                else
                    return null;
            }
        }

        /// <summary>
        ///     Sets perssistant state
        /// </summary>
        /// <param name="name">Name of state</param>
        /// <param name="value">Value to set or null</param>
        public void SetPersistentState(string name, object? value)
        {
            _ = ConnectionString ??
                throw new NullReferenceException("Connection string cannot be null, please set");

            using (var c = new StateDbContext(ConnectionString))
            {
                var prop = c.States.FirstOrDefault(n => n.PropName == name);

                if (prop is null)
                {
                    if (value is null)
                        return; // No value allready

                    var state = new State()
                    {
                        PropName = name,
                        IntValue = (value is int) ? (int)value : null,
                        DoubleValue = (value is double) ? (double)value : null,
                        StringValue = (value is string) ? (string)value : null
                    };
                    c.Add(state);
                    c.SaveChanges();
                }
                else
                {
                    // update existing
                    if (value is null)
                    {
                        c.Remove<State>(prop);
                        c.SaveChanges();
                        return;
                    }

                    prop.IntValue = (value is int) ? (int)value : null;
                    prop.DoubleValue = (value is double) ? (double)value : null;
                    prop.StringValue = (value is string) ? (string)value : null;
                    c.SaveChanges();
                }
            }
        }
    }
}