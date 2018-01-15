//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.TowerAIComponent towerAI { get { return (Components.TowerAIComponent)GetComponent(GameComponentsLookup.TowerAI); } }
    public bool hasTowerAI { get { return HasComponent(GameComponentsLookup.TowerAI); } }

    public void AddTowerAI(float newCounter, float newRange, float newShootspeed) {
        var index = GameComponentsLookup.TowerAI;
        var component = CreateComponent<Components.TowerAIComponent>(index);
        component.counter = newCounter;
        component.range = newRange;
        component.Shootspeed = newShootspeed;
        AddComponent(index, component);
    }

    public void ReplaceTowerAI(float newCounter, float newRange, float newShootspeed) {
        var index = GameComponentsLookup.TowerAI;
        var component = CreateComponent<Components.TowerAIComponent>(index);
        component.counter = newCounter;
        component.range = newRange;
        component.Shootspeed = newShootspeed;
        ReplaceComponent(index, component);
    }

    public void RemoveTowerAI() {
        RemoveComponent(GameComponentsLookup.TowerAI);
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

    static Entitas.IMatcher<GameEntity> _matcherTowerAI;

    public static Entitas.IMatcher<GameEntity> TowerAI {
        get {
            if (_matcherTowerAI == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TowerAI);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTowerAI = matcher;
            }

            return _matcherTowerAI;
        }
    }
}
