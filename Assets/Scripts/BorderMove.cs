using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderMove : MonoBehaviour
{
    [SerializeField] GameObject playerSprite;
    [SerializeField] GameObject ghostSprite;
    
    public Tweener tweener;
    public Vector3 target = new Vector3(6, 0, 0);
    public Vector3 target2 = new Vector3(-6, 4, 0);
    public float speed;

    void Start()
    {
        playerSprite.transform.position = new Vector3(-6,0,0);
        ghostSprite.transform.position = new Vector3(6, 4, 0);
    }


    void Update()
    {
        MovePlayerSprite();
        MoveGhostSprite();
    }

    void MovePlayerSprite()
    {
        if (tweener != null)
        {
            if (!tweener.TweenExists(playerSprite.transform))
            {
                tweener.AddTween(playerSprite.transform, playerSprite.transform.position, target, speed);
            }
            if (playerSprite.transform.position == target)
            {
                target.x = -target.x;
            }

        }

    }

    void MoveGhostSprite()
    {

        if (!tweener.TweenExists(ghostSprite.transform))
        {
            tweener.AddTween(ghostSprite.transform, ghostSprite.transform.position, target2, speed);
        }

        if (ghostSprite.transform.position == target2)
        {
            target2.x = -target2.x;
        }
    }
}
