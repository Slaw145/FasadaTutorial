using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada
{
    public class Container
    {
        readonly Dictionary<Type, Type>
        services = new Dictionary<Type, Type>();

        public void Register<TRegister, TImplement>()
        {
            services.Add(typeof(TRegister), typeof(TImplement));
        }

        public T Resolve<T>()
        {
            Type type = services[typeof(T)];

            return (T)Activator.CreateInstance(type);
        }
    }
}
