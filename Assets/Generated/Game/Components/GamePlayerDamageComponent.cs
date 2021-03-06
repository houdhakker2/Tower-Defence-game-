//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Components.PlayerDamageComponent playerDamageComponent = new Components.PlayerDamageComponent();

    public bool isPlayerDamage {
        get { return HasComponent(GameComponentsLookup.PlayerDamage); }
        set {
            if (value != isPlayerDamage) {
                var index = GameComponentsLookup.PlayerDamage;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : playerDamageComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherPlayerDamage;

    public static Entitas.IMatcher<GameEntity> PlayerDamage {
        get {
            if (_matcherPlayerDamage == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PlayerDamage);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlayerDamage = matcher;
            }

            return _matcherPlayerDamage;
        }
    }
}
