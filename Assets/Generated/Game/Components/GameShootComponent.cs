//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.ShootComponent shoot { get { return (Components.ShootComponent)GetComponent(GameComponentsLookup.Shoot); } }
    public bool hasShoot { get { return HasComponent(GameComponentsLookup.Shoot); } }

    public void AddShoot(UnityEngine.Transform newEnemy) {
        var index = GameComponentsLookup.Shoot;
        var component = CreateComponent<Components.ShootComponent>(index);
        component.enemy = newEnemy;
        AddComponent(index, component);
    }

    public void ReplaceShoot(UnityEngine.Transform newEnemy) {
        var index = GameComponentsLookup.Shoot;
        var component = CreateComponent<Components.ShootComponent>(index);
        component.enemy = newEnemy;
        ReplaceComponent(index, component);
    }

    public void RemoveShoot() {
        RemoveComponent(GameComponentsLookup.Shoot);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherShoot;

    public static Entitas.IMatcher<GameEntity> Shoot {
        get {
            if (_matcherShoot == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Shoot);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherShoot = matcher;
            }

            return _matcherShoot;
        }
    }
}
