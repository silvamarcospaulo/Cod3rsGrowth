using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Singleton
{
    public sealed class SingletonTabelas<T> where T : class, new()
    {
        public static T instance;
        public static T Instance()
        {
            lock (typeof(T))
            {
                if (instance == null)
                {
                    instance = new T();
                }
            }
            return instance;
        }
    }
}