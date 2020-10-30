### Installation

- Installez MySQL Installer
- À partir de MySQL Installer, créez une instance de MySQL Server 8.0 avec la configuration spécifiée dans le fichier appsettings.json
- Installez MySQL Workbench et créez une nouvelle connexion au serveur que vous venez de créer 
- À partir de MySQL Workbench, exécuter le script "CreateDatabase.sql" pour générer la base de données initiale (File -> Open SQL Script, Execute)
- Ouvrez dans Visual Studio le projet et commencer à trouver les vulnérabilités

### Mise en place serveur

- Ouvrez VS Code dans le root du projet et installer les dependances
- Lancez le serveur, il doit rouler en localhost sur le port 5000 pour HTTP et 5001 pour HTTPS

### Simuler les attaques

- Dans le répertoire Scripts/Attaques, simplement lancer les .exe pour simuler les attaques

### Explication de la structure du code

- Dossier Models

  - Le dossier "Models" contient les classes qui sont en lien avec la base de données
  - Les classes avec "context" à la fin permettent d'interfacer directement les classes de l'application avec les tables dans la base de données
  - Si vous voulez ajouter une nouvelle classe et une nouvelle table, vous devez l'ajouter dans les variables de app3Context

- Dossier Controllers
  - Ce dossier contient un contrôlleur qui est utilisé afin d'implémenter les routes nécessaires

PS : Assurez-vous que lorsque vous tester une requête avec Postman d'envoyer le bon format de données dans le corps de la requête
