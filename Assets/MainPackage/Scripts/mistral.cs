using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.scripts
{
    

public class EnemyAI : MonoBehaviour
    {
        public Transform target; // player's pos(and velocity)

        public float moveSpeed = 3f;
        public float rotationSpeed = 3f;

        private Rigidbody enemyRigidbody;

        private void Awake()
        {
            enemyRigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
           
            if (Vector3.Distance(transform.position, target.position) <= 30f)
            {
                
                Vector3 direction = target.position - transform.position;
                direction.y = 0; 

                
                Quaternion toRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);

               
                enemyRigidbody.velocity = direction.normalized * moveSpeed * Time.deltaTime;
            }
            else
            {
                
                enemyRigidbody.velocity = Vector3.zero;
            }
        }
    }
}

