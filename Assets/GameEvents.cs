//using Action = System.ActionExt;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Define game event
public static class GameEvents
{
    public static Action PVP;
    public static Action PVE;
    public static Action Play;
    public static Action GameOver;
    public static Action<State> CurrentState;
}

//Mo rong Action them Func Raise() de kiem tra xem action co null khong moi thuc hien hanh goi Invoke() action
public static class ActionExt
{
    public static void Raise(this Action action)
    {
        if (action != null)
        {
            action();
        }
    }
    public static void Raise<T>(this Action<T> action, T obj)
    {
        if (action != null)
        {
            action.Invoke(obj);
        }
    }
    public static void Raise<T1, T2>(this Action<T1, T2> action, T1 obj1, T2 obj2)
    {
        if (action != null)
        {
            action.Invoke(obj1, obj2);
        }
    }
    public static void Raise<T1, T2, T3>(this Action<T1, T2, T3> action, T1 obj1, T2 obj2, T3 obj3)
    {
        if (action != null)
        {
            action.Invoke(obj1, obj2, obj3);
        }
    }
}