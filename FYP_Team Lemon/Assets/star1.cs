//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class star1 : MonoBehaviour
//{
//    public static int star = 0;
//    public GameObject Star;
//    void Start()
//    {
//        Star.SetActive(true);
//    }
//    void Update()
//    {
//        if (star == 1)
//        {
//            Star.SetActive(false);
//        }
//    }
//    void OnTriggerEnter(Collider other)
//    {
//        if (other.tag == "Player")
//        {
//            Destroy(gameObject);
//            if (starmanager.star1collect == 0 && starmanager.star2collect == 0 && starmanager.star3collect == 0)
//            {
//                starmanager.star1collect = 1;
//            }
//            else if (starmanager.star1collect == 1 && starmanager.star2collect == 0 && starmanager.star3collect == 0)
//            {
//                starmanager.star2collect = 1;
//            }
//            else if (starmanager.star1collect == 1 && starmanager.star2collect == 1 && starmanager.star3collect == 0)
//            {
//                starmanager.star3collect = 1;
//            }
//            star = 1;
//        }
//    }
//}