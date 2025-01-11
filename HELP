# 📦・Comment l'utiliser

## 🔍・Introduction

Tout d'abord pour crée une nouvelle configuration vous devrez crée une ```class``` qui heritras de ```Json.Component<MaClass>``` une fois que celle ci herite de ceci
Exemple d'une ```class```
```C#
public class MyConfig : Json.Component<MyConfig>
{
  public int Amount = 500;
}
```
Vous devrez initialiser le Plugin dans le ```OnPluginInit()``` comme ceci ```MaClass.Init();```
Une fois que vous aurez fait ceci le Plugin sera prêt a l'emploi

## 📚・Obtenir une valeur inscrite dans la Configuration

pour obtenir une valeur enregistrer dans le fichier config vous pouvez faire comme ceci
*Comme exemple ajour la valeur* ***Amount*** *en argent au joueur*
```C#
player.AddMoney(MyConfig.Request().Amount);
```

## 📦・Mettre a jour une valeur

Pour mettre a jour une valeur vous devrez faire comme ceci
```C#
MyConfig.Update(c =>
{
  c.Amount = 1000;
});
```
*La par exemple la valeur va passer de* ***500*** *à* ***1000***

*La modification de valeur enregistre elle même les donées modifier*
