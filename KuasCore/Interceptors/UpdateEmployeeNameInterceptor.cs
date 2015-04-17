using AopAlliance.Intercept;
using KuasCore.Models;
using System;
using System.Diagnostics;

namespace KuasCore.Interceptors
{
    class UpdateEmployeeNameInterceptor : IMethodInterceptor
    {

        public object Invoke(IMethodInvocation invocation)
        {
            Console.WriteLine("UpdateEmployeeNameInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("UpdateEmployeeNameInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);

            object result = invocation.Proceed();

            if (result is Employee)
            {
                Employee employees = (Employee)result;
                employees.Name += "偷偷加東西";
                result = employees;
            }

            Console.WriteLine("回傳的資料已取得 [{0}]", result);
            Debug.Print("回傳的資料已取得 [{0}]", result);
            return result;
        }
    }
}
