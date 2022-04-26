using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    //Metodlarımızın çatısı
    //Mesela validation kurallarının metodun başında çalışmasını istiyoruz bunun için Aspect'te OnBefore'u doldururuz. 
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        public override void Intercept(IInvocation invocation)
        {
            //Metodu ne zaman çalıştırmak istersin? 
            //OnBefore yani metodun başında çalışır.
            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }
    }
}
