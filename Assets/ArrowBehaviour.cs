using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBehaviour : MonoBehaviour
{
    public Transform target;
    public float target_direction;
    public float distance;
    public float deltaX;
    public float deltaY;
    public float current_dir;
    public float dir_diff;
    public float dir_diff_origin;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.up * Time.deltaTime);
        deltaX = target.position.x - transform.position.x;
        deltaY = target.position.y - transform.position.y;
        current_dir = transform.rotation.eulerAngles.z;


        distance = Mathf.Sqrt(Mathf.Abs(Mathf.Pow(deltaX, 2) + Mathf.Pow(deltaY, 2)));

        if (deltaX < 0)
        {
            target_direction = (Mathf.Asin(-deltaY / distance) * Mathf.Rad2Deg) + 90;
        }
        else
        {
            target_direction = Mathf.Asin(deltaY / distance) * Mathf.Rad2Deg + 270;
        }

        dir_diff = target_direction - current_dir;
        dir_diff_origin = target_direction < current_dir ? (target_direction - 360) + current_dir : (current_dir - 360) + target_direction;

        if (dir_diff > dir_diff_origin)
        {
            //transform.Rotate(Vector3.forward, -50 * Time.deltaTime);
        }
        else
        {
            //transform.Rotate(Vector3.forward, 50 * Time.deltaTime);
        }


        //if (target_direction > current_dir)
        //{
        //    transform.Rotate(Vector3.forward, 50 * Time.deltaTime);
        //}
        //else
        //{
        //    transform.Rotate(Vector3.forward, -50 * Time.deltaTime);
        //}
    }
}
