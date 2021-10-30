using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCommand : Command
{
    PlayerShooting playerShooting;
    // Start is called before the first frame update
    public ShootCommand(PlayerShooting _playerShooting)
    {
        playerShooting = _playerShooting;
    }
    public override void Execute()
    {
        playerShooting.Shoot();
    }
    public override void UnExecute()
    {
        
    }
   
}
