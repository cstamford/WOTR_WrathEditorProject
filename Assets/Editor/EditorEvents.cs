using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public interface IEditorEvent  {
    public int Order { get; }
}

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class InvokeOnEditorLoad : Attribute, IEditorEvent {
    public InvokeOnEditorLoad(int order = 0) => Order = order;
    public int Order { get; }
}

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class InvokeOnEditorUnload : Attribute, IEditorEvent {
    public InvokeOnEditorUnload(int order = 0) => Order = order;
    public int Order { get; }
}

[InitializeOnLoad]
public static class EditorEvents {
    static EditorEvents() {
        SafeInvoke<InvokeOnEditorLoad>();

        AssemblyReloadEvents.beforeAssemblyReload += SafeInvoke<InvokeOnEditorUnload>;
        EditorApplication.quitting += SafeInvoke<InvokeOnEditorUnload>;
    }

    private static void SafeInvoke<T>() where T : Attribute, IEditorEvent => SafeInvoke<T>(typeof(T).Name);
    private static void SafeInvoke<T>(string evt) where T : Attribute, IEditorEvent {
        foreach (MethodInfo method in GetMethods<T>()) {
            Debug.Log($"[EditorEvents.{evt}] Invoking {method.Name}...");

            try {
                method.Invoke(obj: null, parameters: null);
            } catch (Exception ex) {
                Debug.LogError($"[EditorEvents.{evt}] Failed to invoke {method.Name}: {ex}");
            }
        }
    }

    private static IEnumerable<MethodInfo> GetMethods<T>() where T : Attribute, IEditorEvent => Assembly
        .GetExecutingAssembly()
        .GetTypes()
        .SelectMany(t => t.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
        .Where(m => m.GetCustomAttribute<T>() != null)
        .OrderBy(m => m.GetCustomAttribute<T>().Order);
}
