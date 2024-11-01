using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static Controls controls;
    private static Vector3 mousePos;

    public static Vector3 GetMousePos()
    {
        return mousePos;
    }

    //Activates player controls;
    public static void Init(Player player)
    {
        controls = new Controls();

        controls.InGame.Movement.performed += _ =>
        {
            player.SetMoveDirection(_.ReadValue<Vector3>());
        };
        
        controls.InGame.MousePos.performed += _ =>
        {
            mousePos = _.ReadValue<Vector2>();
        };
        

    }
    public static void EnableInGame()
    {
        controls.InGame.Enable();
    }
}
