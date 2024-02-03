using System.Collections;
using System.Collections.Generic;
using Unity Engine;

// I want to say the bottom two declares the type as public, since C# recquires you to declare first 
public AudioExample : MonoBehavior 
{
    public AudioClip source;
    public AudioClip clip;

    
//voidUpd
    voidUpdate()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            source.PlayOneShot(clip);
        }
    }

}