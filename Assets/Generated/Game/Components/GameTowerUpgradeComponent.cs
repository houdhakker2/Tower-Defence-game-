//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Components.TowerUpgradeComponent towerUpgradeComponent = new Components.TowerUpgradeComponent();

    public bool isTowerUpgrade {
        get { return HasComponent(GameComponentsLookup.TowerUpgrade); }
        set {
            if (value != isTowerUpgrade) {
                var index = GameComponentsLookup.TowerUpgrade;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : towerUpgradeComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherTowerUpgrade;

    public static Entitas.IMatcher<GameEntity> TowerUpgrade {
        get {
            if (_matcherTowerUpgrade == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TowerUpgrade);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTowerUpgrade = matcher;
            }

            return _matcherTowerUpgrade;
        }
    }
}
