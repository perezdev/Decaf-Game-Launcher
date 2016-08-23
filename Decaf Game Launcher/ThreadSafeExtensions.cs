using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace Decaf_Game_Launcher
{
    public static class ThreadSafeExtensions
    {
        private delegate void SetThreadSafePropertyDelegate<T>(
            Control control, Expression<Func<T>> property, T value);
        private delegate T GetThreadSafePropertyDelegate<T>(Control control, Expression<Func<T>> property);
        private delegate void InvokeThreadSafeMethodDelegate(Control control, Expression<Action> method);
        private delegate T InvokeThreadSafeFunctionDelegate<T>(Control control, Expression<Func<T>> function);


        /// <summary>
        /// Sets the specified property of this control to the specified value safely across threads by invoking a delegate if necessary.
        /// </summary>
        /// <typeparam name="T">The type of the property. Can usually be inferred from usage.</typeparam>
        /// <param name="control">The control to set the property on.</param>
        /// <param name="property">The property to set as a lambda expression.</param>
        /// <param name="value">The new value of the property.</param>
        public static void SetThreadSafeProperty<T>(this Control control, Expression<Func<T>> property, T value)
        {
            if (control.InvokeRequired)
            {
                var del = new SetThreadSafePropertyDelegate<T>(SetThreadSafeProperty);
                control.Invoke(del, control, property, value);
            }
            else
            {
                PropertyInfo propertyInfo = GetPropertyInfo(property);
                if (propertyInfo != null)
                {
                    propertyInfo.SetValue(control, value, null);
                }
            }
        }

        /// <summary>
        /// Gets the value of the specified property of this control safely across threads by invoking a delegate if necessary.
        /// </summary>
        /// <typeparam name="T">The type of the property. Can usually be inferred from usage.</typeparam>
        /// <param name="control">The control to get the property from.</param>
        /// <param name="property">The property to get the value from as a lambda expression.</param>
        /// <returns>The value of the specified property.</returns>
        public static T GetThreadSafeProperty<T>(this Control control, Expression<Func<T>> property)
        {
            if (control.InvokeRequired)
            {
                var del = new GetThreadSafePropertyDelegate<T>(GetThreadSafeProperty);
                return (T)control.Invoke(del, control, property);
            }
            else
            {
                PropertyInfo propertyInfo = GetPropertyInfo(property);
                if (propertyInfo != null)
                {
                    return (T)propertyInfo.GetValue(control, null);
                }
            }
            return default(T);
        }

        /// <summary>
        /// Invokes a method of this control safely across threads by invoking a delegate if necessary.
        /// </summary>
        /// <param name="control">The control to invoke the method on.</param>
        /// <param name="method">The method to invoke as an expression.</param>
        public static void InvokeThreadSafeMethod(this Control control, Expression<Action> method)
        {
            if (control.InvokeRequired)
            {
                var del = new InvokeThreadSafeMethodDelegate(InvokeThreadSafeMethod);
                control.Invoke(del, control, method);
            }
            else
            {
                try
                {
                    method.Compile().DynamicInvoke();
                }
                catch (Exception ex)
                {
                    //I'm throwing an exception here just so it's easier to see the inner exception easier
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }
        }

        /// <summary>
        /// Invokes a function of this control safely across threads by invoking a delegate if necessary.
        /// </summary>
        /// <param name="control">The control to invoke the function on.</param>
        /// <param name="function">The function to invoke as an expression</param>
        public static T InvokeThreadSafeFunction<T>(this Control control, Expression<Func<T>> function)
        {
            if (control.InvokeRequired)
            {
                var del = new InvokeThreadSafeFunctionDelegate<T>(InvokeThreadSafeFunction);
                return (T)control.Invoke(del, control, function);
            }
            else
            {
                return (T)function.Compile().DynamicInvoke();
            }
        }

        private static MemberInfo GetMemberInfo(Expression expression)
        {
            MemberExpression memberExpression;
            LambdaExpression lambda = (LambdaExpression)expression;
            if (lambda.Body is UnaryExpression)
            {
                UnaryExpression unaryExpression = (UnaryExpression)lambda.Body;
                memberExpression = (MemberExpression)unaryExpression.Operand;
            }
            else
            {
                memberExpression = (MemberExpression)lambda.Body;
            }

            return memberExpression.Member;
        }

        private static PropertyInfo GetPropertyInfo(Expression expression)
        {
            MemberInfo memberInfo = GetMemberInfo(expression);
            if (memberInfo.MemberType == MemberTypes.Property)
            {
                return (PropertyInfo)memberInfo;
            }
            return null;
        }
    }
}
