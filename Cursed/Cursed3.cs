using System;
using System.Reflection;
using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.Cursed
{
    internal class Cursed3 : ICursed
    {
        public static string Name { get; set; } = "Create instance of abstract class";

        public void Curse()
        {
            // Get type and ctor
            Type typeLogger = typeof(Logger);
            ConstructorInfo magicConstructor = typeLogger.GetConstructor(Type.EmptyTypes);

            // Some funny things
            Type TypeRuntimeMethodHandle = typeof(RuntimeMethodHandle);
            MethodInfo magicMethod = TypeRuntimeMethodHandle.GetMethod("InvokeMethod", BindingFlags.Static | BindingFlags.NonPublic);

            // Get info and other
            PropertyInfo sigInfo = magicConstructor.GetType().GetProperty("Signature", BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);
            
            // Magic stuff
            Logger abstrObj = (Logger)magicMethod.Invoke(null, new object[] { null, null, sigInfo.GetValue(magicConstructor), true, null });

            // Profit
            abstrObj.Id = 566;
            Console.WriteLine(abstrObj.Id);
            Console.WriteLine(abstrObj.GetType().ToString());
        }
    }

    // Just class for example
    public abstract class Logger
    {
        public Logger() { }
        public int Id { get; set; }
    }
}
