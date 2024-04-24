using System.Collections;
using UnityEngine;

public class CharacterDie : MonoBehaviour
{
    [SerializeField] private string animatorParametrName;

    private ParticleSystem _deathPS;
    private void Awake()
    {
        _deathPS = GetComponent<ParticleSystem>();
    }
    private void OnEnable()
    {
        CollisionsHandler.CharacterHitted += OnCharacterDie;
    }

    public void OnCharacterDie()
    {
        StartCoroutine(Dying());
    }
    private IEnumerator Dying()
    {
        _deathPS.Play();
        yield return new WaitForSecondsRealtime(_deathPS.totalTime);
        Destroy(gameObject);
    }

    private void OnDisable()
    {
        CollisionsHandler.CharacterHitted -= OnCharacterDie;
    }
}
