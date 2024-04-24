using System;
using UnityEngine;

public class CollisionsHandler : ObjectCollision
{
    public static event Action CharacterHitted;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(neededTag))
        {
            CharacterHitted?.Invoke();
        }
    }
}
