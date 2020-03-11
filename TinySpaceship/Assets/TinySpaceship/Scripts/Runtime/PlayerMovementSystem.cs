using Unity.Entities;
using Unity.U2D.Entities.Physics;

//using Unity.U2D.Entities.Physics;

public class PlayerMovementSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        var physicsWorldSystem = World.GetExistingSystem<PhysicsWorldSystem>();
        var physicsWorld = physicsWorldSystem.PhysicsWorld;

        Entities.WithAll<PlayerMovement>().ForEach((Entity playerEntity, ref PhysicsColliderBlob velocity ) =>
            {

                {
                    
                }
                
            }
            
            );
    }
}
