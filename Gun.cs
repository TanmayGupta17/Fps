using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private LayerMask CubeLayer;
    [SerializeField] private Camera Gcam;
    [SerializeField] public float Damage;
    [SerializeField] public ParticleSystem Muzzleflash;

    private void Start()
    {
        Gcam = Camera.main;
    }
   
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        //else if (Input.GetMouseButtonUp(0))
        //{
        //    if (Muzzleflash.isPlaying) Muzzleflash.Pause();
        //    //Muzzleflash.SetActive(false);
        //}
    }

    void Shoot()
    {

        //if (!Muzzleflash.isPlaying)
            Muzzleflash.Play();
        //Muzzleflash.SetActive(true);
        Ray GunRay = new Ray(Gcam.transform.position, Gcam.transform.forward);
            if (Physics.Raycast(GunRay, out RaycastHit hit, 100f, CubeLayer))
            {
                if (hit.collider.gameObject.TryGetComponent(out Target cubehit))
                {
                    cubehit.SubtractHealth(Damage);
                    Debug.Log(cubehit.health);
                }
            }

       
    }
}
