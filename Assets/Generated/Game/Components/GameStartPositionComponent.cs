//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.StartPositionComponent startPosition { get { return (Components.StartPositionComponent)GetComponent(GameComponentsLookup.StartPosition); } }
    public bool hasStartPosition { get { return HasComponent(GameComponentsLookup.StartPosition); } }

    public void AddStartPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.StartPosition;
        var component = CreateComponent<Components.StartPositionComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceStartPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.StartPosition;
        var component = CreateComponent<Components.StartPositionComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveStartPosition() {
        RemoveComponent(GameComponentsLookup.StartPosition);
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

    static Entitas.IMatcher<GameEntity> _matcherStartPosition;

    public static Entitas.IMatcher<GameEntity> StartPosition {
        get {
            if (_matcherStartPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.StartPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherStartPosition = matcher;
            }

            return _matcherStartPosition;
        }
    }
}
