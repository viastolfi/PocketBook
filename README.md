# Rendu TP MVVM 

## Vincent Astolfi

prendre le dernier commit en compte

### Fonctionnel

- Navigation à l'aide de ViewModel Applicatif et de Command
- Chargement des données du Stub à l'aide de ViewModel Wrapper utilsant des Commands personnalisées 
- Binding des données dans les différentes pages
- Affichage de la liste des livres (AllBooksPage) puis possibilités d'aller sur la page de Description du livre (SpecificBookDescriptionPage)
- Possibilité de changer le statut de lecture d'un livre entre Read et Unread
- Utilisation de mon propre ToolKit pour notifier le changement des données

### Non fonctionnel

- Lors du changement de statut dans la page de description, si on reviens en arrière dans la page de tout les livres le changement ne s'affiche pas. Si on reviens encore une fois en arrière sur la MainPage puis que l'on retorune sur la page avec tout les livres le changement est maintenant pris en compte (ça fonctionne si à la place de revenir en arrière depuis la page de description, je navigue vers AllBooksPage directement mais l'éxécution est longue et ça casse la naviguation)
- J'ai fait la classe BaseViewModel dans mon ToolKit mais lorsque je l'utilise certaine partie de mon code ne sont plus fonctionnelle. Ça vient peut être du fait que j'utilise le BaseViewModel de Mr. Chevaldonne mais pas le reste de son Model/Stub
