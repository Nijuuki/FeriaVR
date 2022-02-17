using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DardoAttach : MonoBehaviour
{
    private void OnCollisionEnter(Collision _col)
    {
        if (_col.gameObject.CompareTag("InGame/Dardos/Diana"))
        {
            if (this.TryGetComponent(out Rigidbody rb))
            {
                rb.isKinematic = true;
            }
        }
        if (_col.gameObject.CompareTag("InGame/Dardos/Human"))
        {
            if (this.TryGetComponent(out Rigidbody rb))
            {
                rb.isKinematic = true;
            }
            if(this.transform.Find("Particles/Blood").TryGetComponent(out ParticleSystem ps))
            {
                ps.Play();
            }
        }
    }
}
