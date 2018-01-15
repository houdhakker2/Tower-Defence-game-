//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.DamageComponent damage { get { return (Components.DamageComponent)GetComponent(GameComponentsLookup.Damage); } }
    public bool hasDamage { get { return HasComponent(GameComponentsLookup.Damage); } }

    public void AddDamage(float newDamage) {
        var index = GameComponentsLookup.Damage;
        var component = CreateComponent<Components.DamageComponent>(index);
        component.Damage = newDamage;
        AddComponent(index, component);
    }

    public void ReplaceDamage(float newDamage) {
        var index = GameComponentsLookup.Damage;
        var component = CreateComponent<Components.DamageComponent>(index);
        component.Damage = newDamage;
        ReplaceComponent(index, component);
    }

    public void RemoveDamage() {
        RemoveComponent(GameComponentsLookup.Damage);
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

    static Entitas.IMatcher<GameEntity> _matcherDamage;

    public static Entitas.IMatcher<GameEntity> Damage {
        get {
            if (_matcherDamage == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Damage);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDamage = matcher;
            }

            return _matcherDamage;
        }
    }
}
