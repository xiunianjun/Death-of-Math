<<<<<<< HEAD
using System;
using System.IO;
using System.Linq;

namespace UnityEngine.TestTools
{
    internal static class AttributeHelper
    {
        internal static Type GetTargetClassFromName(string targetClassName, Type attributeInterface)
        {
            Type targetClass = null;
            foreach (var assemblyName in ScriptingRuntime.GetAllUserAssemblies())
            {
                // we need to pass the assembly name without the .dll extension, so removing that first
                var name = Path.GetFileNameWithoutExtension(assemblyName);
                targetClass = Type.GetType(targetClassName + "," + name);
                if (targetClass != null)
                    break;
            }

            if (targetClass == null)
            {
                Debug.LogWarningFormat("Class type not found: " + targetClassName);
                return null;
            }

            ValidateTargetClass(targetClass, attributeInterface);
            return targetClass;
        }

        private static void ValidateTargetClass(Type targetClass, Type attributeInterface)
        {
            var constructorInfos = targetClass.GetConstructors();
            if (constructorInfos.All(constructor => constructor.GetParameters().Length != 0))
            {
                Debug.LogWarningFormat("{0} does not implement default constructor", targetClass.Name);
            }

            if (!attributeInterface.IsAssignableFrom(targetClass))
            {
                Debug.LogWarningFormat("{0} does not implement {1}", targetClass.Name, attributeInterface.Name);
            }
        }
    }
}
=======
using System;
using System.IO;
using System.Linq;

namespace UnityEngine.TestTools
{
    internal static class AttributeHelper
    {
        internal static Type GetTargetClassFromName(string targetClassName, Type attributeInterface)
        {
            Type targetClass = null;
            foreach (var assemblyName in ScriptingRuntime.GetAllUserAssemblies())
            {
                // we need to pass the assembly name without the .dll extension, so removing that first
                var name = Path.GetFileNameWithoutExtension(assemblyName);
                targetClass = Type.GetType(targetClassName + "," + name);
                if (targetClass != null)
                    break;
            }

            if (targetClass == null)
            {
                Debug.LogWarningFormat("Class type not found: " + targetClassName);
                return null;
            }

            ValidateTargetClass(targetClass, attributeInterface);
            return targetClass;
        }

        private static void ValidateTargetClass(Type targetClass, Type attributeInterface)
        {
            var constructorInfos = targetClass.GetConstructors();
            if (constructorInfos.All(constructor => constructor.GetParameters().Length != 0))
            {
                Debug.LogWarningFormat("{0} does not implement default constructor", targetClass.Name);
            }

            if (!attributeInterface.IsAssignableFrom(targetClass))
            {
                Debug.LogWarningFormat("{0} does not implement {1}", targetClass.Name, attributeInterface.Name);
            }
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
