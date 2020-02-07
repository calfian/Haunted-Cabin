using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public GameObject item;
    public GameObject tempParent;
    public Transform guide;

    public SphereCollider box;

    private Rigidbody rb;

    public float throwStrength=10;



    

    private int time = 2;

    // Start is called before the first frame update
    void Start()
    {
        rb = item.GetComponent<Rigidbody>();
       // box = GetComponentInChildren<SphereCollider>();
            rb.useGravity = true;

        

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnMouseDown()
    {
        rb.useGravity = false;
        rb.isKinematic = true;
        item.transform.position = guide.transform.position;
        item.transform.rotation = guide.transform.rotation;
        item.transform.parent = tempParent.transform;
    }

    void OnMouseUp()
    {
        rb.useGravity = true;
        rb.isKinematic = false ;
        item.transform.parent = null;
        item.transform.position = guide.transform.position;
        rb.AddRelativeForce(new Vector3(0, 0, throwStrength), ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("floor"))
        {
            

          StartCoroutine(Coroutine());
            

        }
        else { box.enabled = false; }
    }


    
   
    private IEnumerator Coroutine()
    {
       

            box.enabled = true;
            yield return new WaitForSeconds(1f);
           
            box.enabled = false;
        
    }
    
}
