using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{

    //private Tween activeTween;
    private List<Tween> activeTweens;
    
    void Start()
    {
        activeTweens = new List<Tween>();
    }
    
    void Update()
    {
        Tween activeTween;
        //foreach (Tween activeTween in activeTweens.Reverse<Tween>())
        for (int i = activeTweens.Count-1; i>=0;i--)
        {
            activeTween = activeTweens[i];
            if (Vector3.Distance(activeTween.Target.position, activeTween.EndPos) > 0.1f)
            {
                float t = (Time.time - activeTween.StartTime) / activeTween.Duration;
                //t = Mathf.Pow(t, 3);
                activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, t);
                
            }
            else
            {
                activeTween.Target.position = activeTween.EndPos;
                activeTweens.RemoveAt(i);
                //activeTweens.Remove(activeTween);
                //activeTween = null;
            }
        }

    }

    public bool AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (TweenExists(targetObject) == false)
        {
            activeTweens.Add(new Tween(targetObject, startPos, endPos, Time.time, duration));
            return true;
        }
        else
        {
            return false;
        }

    }

    public bool TweenExists(Transform target)
    {
        foreach (Tween activeTween in activeTweens)
        {
            if (activeTween.Target == target)
            {
                return true;
            }
        }
        return false;
    }

}
