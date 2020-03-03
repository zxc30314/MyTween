using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MyScript.Tween
{
    public class MyTween
    {
        public Action function;
        public Action onComplete;
        public float Delay;

        public MyTween(Action action)
        {
            function += action;
        }
        //public MyTween(params MyTween[] tweens)
        //{
         
           
        //}


    }

    public static class MyTweenExtensions
    {
        public static T OnComplete<T>(this T t, Action action) where T : MyTween
        {
            t.onComplete += action;

            return t;
        }
        public static T SetDelay<T>(this T t, float delay) where T : MyTween {

            t.Delay = delay;
            return t;
        }
    }
}