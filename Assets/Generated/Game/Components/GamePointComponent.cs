//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.PointComponent point { get { return (Components.PointComponent)GetComponent(GameComponentsLookup.Point); } }
    public bool hasPoint { get { return HasComponent(GameComponentsLookup.Point); } }

    public void AddPoint(UnityEngine.Transform newValue) {
        var index = GameComponentsLookup.Point;
        var component = CreateComponent<Components.PointComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePoint(UnityEngine.Transform newValue) {
        var index = GameComponentsLookup.Point;
        var component = CreateComponent<Components.PointComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePoint() {
        RemoveComponent(GameComponentsLookup.Point);
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

    static Entitas.IMatcher<GameEntity> _matcherPoint;

    public static Entitas.IMatcher<GameEntity> Point {
        get {
            if (_matcherPoint == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Point);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPoint = matcher;
            }

            return _matcherPoint;
        }
    }
}
