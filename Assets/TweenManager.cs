using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MyScript.Tween
{
    public class TweenManager : MonoBehaviour
    {


        public static TweenManager instance;

        static TweenManager()
        {
            GameObject go = new GameObject("[Script Manager]");
            DontDestroyOnLoad(go);
            instance = go.AddComponent<TweenManager>();
        }

        public void DoMethod(Action action, float delayTime = 0)
        {
            StartCoroutine(Do(action, delayTime));
      
        }


         IEnumerator Do(Action action, float delayTime) {


            yield return new WaitForSeconds(delayTime);
            action.Invoke();

        }
        public void Play(MyTween tween)
        {
            StartCoroutine(Do(tween));

        }


        IEnumerator Do(MyTween tween)
        {


            yield return new WaitForSeconds(tween.Delay);
            tween.function.Invoke();
            tween.onComplete.Invoke();
        }

    }

}