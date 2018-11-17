
using UnityEngine;

public class Guns : MonoBehaviour {

    public float damage = 1000f;
    public float range = 100f;
    public ParticleSystem MuzzFlash1;
    public ParticleSystem MuzzFlash2;
    public GameObject Impact;
    public AudioSource Shots;
   


    public Camera CarCam;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            
        }
        
    }


    void Shoot()
    { 
         var direction = transform.forward;
         


        MuzzFlash1.Play();
        MuzzFlash2.Play();
        RaycastHit hit;
        if (Physics.Raycast(CarCam.transform.position, CarCam.transform.forward,out hit, range))
        {
            

           GameObject ImpactObj = Instantiate(Impact, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(ImpactObj, .5f);
            Shots.Play();
          
                hit.rigidbody.AddForceAtPosition(40000f * direction, hit.point);

            if (hit.rigidbody.gameObject.tag == "Enemy1")
            {
               
                GameManager.Instance.EnemyHealth1 -= 10;
                if (GameManager.Instance.EnemyHealth1 <= 0)
                {
                    
                    //Destroy(hit.rigidbody.gameObject);

                }
            }
        }

    }

}
