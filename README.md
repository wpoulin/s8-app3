### Installation

- Installer MySQL et rouler le script "CreateDatabase.sql"
- Ouvrir dans visual studio le project et commencer a trouver les vulnerabilites
- Assurez-vous d'avoir la bonne connexion string, voir dans le fichier appsettings.json

### Explication de la structure du code

- Dossier Models

  - Le dossier "Models" contient les classes qui sont en lien avec la base de donnees
  - Les classes avec "context" a la fin permetent d'interfacer directement les classes de l'application avec les tables dans la base de donnees
  - Si vous voulez ajouter une nouvelle classe et une nouvelle table, vous devez l'ajouter dans les variables de app3Context

- Dossier Controllers
  - Ce dossier contient un controlleur qui est utilise afin d'implementer les routes necessaires

PS : Assurez vous que lorsque vous tester un post avec postman d'envoyer le bon format de donnees dans le body
