using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    //Attribute property, field, method, class'lara anlam yüklemek için kullanılır.
    //Log, cache, validation, transaction gibi şeyleri metodların üzerine attribute olarak koyacağız.
    // Inherited = true -> inherit edilen bir noktada da bu attribute çalışabilir anlamına geliyor.
    // priority öncelik anlamına geliyor. Attribute'lar arasında sıralama yapmak isteyebiliriz. 

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
