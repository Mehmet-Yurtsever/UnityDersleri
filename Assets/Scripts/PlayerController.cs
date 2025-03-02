using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
   
    public InputAction MoveAction;
    
    void Start()
    {
        //Debug.Log( "Başlangıç fonksiyonu çalıştı.");
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 150;
        MoveAction.Enable();
    }

  
    void Update()
    {
    /*    float horizontal = 0.0f;
       if (LeftAction.IsPressed())
    {
        horizontal = -1.0f;
    }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {

        horizontal = 1.0f;

        }
        
        float vertical = 0.0f;
        if (Keyboard.current.upArrowKey.isPressed)
        {
        vertical = 1.0f;
        }
        else if (Keyboard.current.downArrowKey.isPressed)
       {
        vertical = -1.0f;
        }
*/
    {
     Vector2 move = MoveAction.ReadValue<Vector2>();
     Debug.Log(move);
     Vector2 position = (Vector2)transform.position + move * 3.0f * Time.deltaTime;
     transform.position = position;
     }
        //Debug.Log( "Güncelleme fonksiyonu çalışıyor.");
    }
}
