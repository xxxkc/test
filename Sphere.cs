using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter(Collision collision)//当物体与其他物体发生碰撞的时候就会调用这个
    //{
    //    print(collision.collider);//可获取和物体发生碰撞物体身上的colider
    //    print(collision.collider.name); //可获取和物体发生碰撞物体的名字
    //}

    //private void OnCollisionExit(Collision collision)//当物体由碰撞变为停止碰撞时调用这个
    //{
    //    print("离开");
    //}

    //private void OnCollisionStay(Collision collision)
    //{
        
    //    int i = 1;
        
    //    print(i);
        
    //}

    private void OnTriggerEnter(Collider other)//进入到该出发区域会触发该方法
    {
        print("进入触发器"+other.name);
    }

    private void OnTriggerExit(Collider other)//当离开这个触发区域会触发该方法
    {
        print("离开触发器");
    }

    private void OnTriggerStay(Collider other)//当物理留在这个触发区域内触发这个方法
    {
        print("在触发器中"+other.name);
    }
}
