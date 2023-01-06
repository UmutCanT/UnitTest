using System.Collections;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class player_movement
{   
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator player_movement_with_positive_vertical_input_moves_forward()
    {
        GameObject playerGameObject = new GameObject("Player");
        Player player = playerGameObject.AddComponent<Player>();
        player.PlayerInput= Substitute.For<IPlayerInput>();
        player.PlayerInput.Vertical.Returns(1f);

        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(playerGameObject.transform);
        cube.transform.localPosition= Vector3.zero;

        yield return new WaitForSeconds(.3f);

        Assert.IsTrue(player.transform.position.z > 0f);
        Assert.AreEqual(0f, player.transform.position.y);
        Assert.AreEqual(0f, player.transform.position.x);
    }
}
