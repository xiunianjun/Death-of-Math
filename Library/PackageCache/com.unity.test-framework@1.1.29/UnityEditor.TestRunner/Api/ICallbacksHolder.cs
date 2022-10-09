<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.Api
{
    internal interface ICallbacksHolder
    {
        void Add(ICallbacks callback, int priority);
        void Remove(ICallbacks callback);
        ICallbacks[] GetAll();
        void Clear();
    }
=======
namespace UnityEditor.TestTools.TestRunner.Api
{
    internal interface ICallbacksHolder
    {
        void Add(ICallbacks callback, int priority);
        void Remove(ICallbacks callback);
        ICallbacks[] GetAll();
        void Clear();
    }
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
}