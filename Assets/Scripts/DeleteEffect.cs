using System.Collections;
using UnityEngine;

public class DeleteEffect : MonoBehaviour
{
    private void Start() => StartCoroutine(DestroyingObject());

    private IEnumerator DestroyingObject()
    {
     yield return new WaitForSeconds(0.4f);
     gameObject.SetActive(false);
    }
}
