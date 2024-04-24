using System.Collections;
using UnityEngine;

public class LoadingController : MonoBehaviour
{
    [SerializeField] private float loadingTime = 1.5f;
    void Start()
    {
        StartCoroutine(MakeLoading());
    }
    private IEnumerator MakeLoading()
    {
        yield return new WaitForSeconds(loadingTime);
        this.gameObject.SetActive(false);
    }
}
