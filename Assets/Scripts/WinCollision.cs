using UnityEngine;

public class WinCollision : ObjectCollision
{
    [SerializeField] private GameObject winMenu;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(neededTag))
        {
            winMenu.SetActive(true);
        }
    }
}
