using System.Collections;
using System.Collections.Generic;
using Unity Engine;

// You will also need to make an Audio Source your object 
public AudioExample : MonoBehavior 
{
    public AudioClip source;
    public AudioClip clip;

    
    voidUpdate()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            source.PlayOneShot(clip);
        }
    }

}
