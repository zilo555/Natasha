﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Natasha.CSharp.HotExecutor.Component
{
    public static class DelegateHelper<T>
    {
        public static Action<T>? Execute;
        public static void GetDelegate(string methodName,BindingFlags flags)
        {
            var methodInfo = typeof(T).GetMethod(methodName, flags);
            if (methodInfo != null)
            {
                Execute = (Action<T>)Delegate.CreateDelegate(typeof(Action<T>), methodInfo);
            }
            else
            {
                throw new InvalidOperationException($"Method {methodName} not found in type {typeof(T)}");
            }
        }
    }
    public static class DelegateHelper<T,R>
    {
        public static Action<T,R>? Execute;
        public static void GetDelegate(string methodName, BindingFlags flags)
        {
            var methodInfo = typeof(T).GetMethod(methodName, flags);
            if (methodInfo != null)
            {
                Execute = (Action<T, R>)Delegate.CreateDelegate(typeof(Action<T, R>), methodInfo);
            }
            else
            {
                throw new InvalidOperationException($"Method {methodName} not found in type {typeof(T)}");
            }
        }
    }
}
