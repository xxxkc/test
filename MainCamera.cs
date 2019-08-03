using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform hero;//hero身上的transform组件确定hero的位置

    private Vector3 offest;//偏移
    // Start is called before the first frame update
    void Start()
    {
        offest = transform.position - hero.position;//偏移=当前位置-hero位置
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = hero.position + offest;
    }
}
