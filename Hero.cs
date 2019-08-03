using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;//NavMeshAgent所在的命名空间

public class Hero : MonoBehaviour
{

    public NavMeshAgent nav;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//讲鼠标位置转化成射线
            //Ray ray=Camera.main.ScreenPointToRay(Input .mousePosition)
            RaycastHit hit;//用来存碰撞信息
            //RaycastHit hit;
            //if (Physics.Raycast(ray, out hit))
            //{
            //    nav.SetDestination(hit.point)
            //}
            if (Physics.Raycast(ray, out hit)) ;//射线检测
            {
                //hit.point;//点击地面上的位置
                //print(hit.point );
                nav.SetDestination(hit.point);//设置目标位置
            }
        }
        //anim.SetFloat("Speed",nav.velocity.magnitude);
        anim.SetFloat("Speed",nav.velocity.magnitude);//获取nav中的速度的大小  nav.velocity.magnitude
    }
}
