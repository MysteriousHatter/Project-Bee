using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBackground : MonoBehaviour
{
    [SerializeField] float scrollSpeed = .5f;
    Material myMaterial;
    Vector2 offset;

    private void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
        offset = new Vector2(scrollSpeed, 0f);
    }

    private void Update()
    {
        myMaterial.mainTextureOffset += offset * Time.deltaTime;
    }
}
