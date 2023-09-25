## Documentation technique
### Configurer la taille de la map
Dans la scene **GameScene** mettre la valeur voulu dans GridManager configurer width et height ex: width: 10 et height 10;
### Faire spawn des bateaux :
Aller dans boatManager mettre les bateaux de type BasicBoat et LongRangeBoat (ceux qui sont dans BoatManager > Classes) dans la liste AllyBoats[].

 Ensuite mettre les bateaux ennemies voulus de type BasicEnemyBoat et LongRangeEnemyBoat dans la liste EnemyBoats[].

### Creer une nouvelle classe :
Prendre une classe déjà existante dans BoatManager > Classes et changer le valeurs maxHP, AttackRange Mouvements etc... Mettre un sprite de couleur jaune.

Ensuite il faut creer le même pour l'enemie faire les même étape que au dessus. Mettre un sprite violet et l'inversé dans l'axe x et chocher isEnemy

### Bouger la camera :

ZQSD Z -> Haut, Q -> Gauche, S -> Bas, D -> Droite
Mollette pour le zoom et dezoom

Changer la vitesse de mouvement de la camera avec les variables serialize
* Mollette et directionnels

### Jeu 

Cliquer sur une unité de l'équipe en cours de tour la deplacer en cliquant sur une tuile, attaquer une unité adverse.

Passer son tour avec le bouton EndTurn

### Base
* Main Camera
* Grid Manager -> GameObject de la grille
    * Tile -> Tuile de la grille 

### UI
* GameTitleContainer -> Titre du jeu
* TurnContainer -> Visualisation du tour en cours
* LifeVisualizeContainer -> Visualisation de la vie du bateau selectionné
* ButtonsContainer -> Boutons pour attaquer, finir son tour

### Gameplay
* BoatMovement
* BoatAttack
* PlayerInput
* SelectionManager

### Gestionnaire d'unités
* Classes -> listes les patrons des Classes
* BasicBoat, LongRangeBoat -> Bateau spawn sur la grille

## Assets externes 
### UI : Fantasy Wooden GUI  Free
 Boutons, Cadres

### Images: 
Sprites de bateaux, Modifications pour être dans l'esprit du jeu, Images trouvés

### TextMeshPro
