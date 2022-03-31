//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSources.Components.ObstComponents.IdComponent id { get { return (EcsSources.Components.ObstComponents.IdComponent)GetComponent(GameComponentsLookup.Id); } }
    public bool hasId { get { return HasComponent(GameComponentsLookup.Id); } }

    public void AddId(int newId) {
        var index = GameComponentsLookup.Id;
        var component = (EcsSources.Components.ObstComponents.IdComponent)CreateComponent(index, typeof(EcsSources.Components.ObstComponents.IdComponent));
        component.Id = newId;
        AddComponent(index, component);
    }

    public void ReplaceId(int newId) {
        var index = GameComponentsLookup.Id;
        var component = (EcsSources.Components.ObstComponents.IdComponent)CreateComponent(index, typeof(EcsSources.Components.ObstComponents.IdComponent));
        component.Id = newId;
        ReplaceComponent(index, component);
    }

    public void RemoveId() {
        RemoveComponent(GameComponentsLookup.Id);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherId;

    public static Entitas.IMatcher<GameEntity> Id {
        get {
            if (_matcherId == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Id);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherId = matcher;
            }

            return _matcherId;
        }
    }
}