using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyScript;
using MyScript.Tween;

public class Test : MonoBehaviour
{
    GameObject go;
    // Start is called before the first frame update
    void Start()
    {

      

      
        for (int i = 0; i < 10; i++)
        {
          
            int index = 0;
            index = i;
            MyTween tween = new MyTween(() => go = new GameObject()).SetDelay(2).OnComplete(() => go.name = index.ToString());
            TweenManager.instance.Play(tween);
           
          
        }

    }

    // Update is called once per frame
    void Update()
    {


    }
}
