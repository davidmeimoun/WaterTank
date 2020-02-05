# WaterTank

#Enigme WaterTank

Etant donné deux réservoirs vides de contenance X et Y (ou X et Y sont des entiers strictement positifs), comment obtenir précisément T litres dans l’un des deux réservoirs (T étant un entier).
On peut remplir ou vider un réservoir, et transvaser le contenu de l’un dans l’autre, jusqu’à ce que la source soit vide ou la destination pleine.

Par exemple, pour obtenir 4 litres avec des réservoirs de contenance 5L et 3L, il faut procéder de la manière suivante :

1) Remplir le réservoir de 5L
2)Transvaser le réservoir de 5L dans le réservoir de 3L, il reste alors 2L dans le réservoir de 5L
3) Vider le réservoir de 3L
4) Transvaser le réservoir de 5L dans le réservoir de 3L, qui contient alors 2L
5) Remplir le réservoir de 5L
6) Transvaser le réservoir de 5L dans le réservoir de 3L. Le réservoir de 5L contient alors 4L

Si on note A et B les deux réservoirs, le couple (x,y) le volume d’eau contenu dans les réservoir A et B respectivement, *->A le remplissage de A, A->* le vidage de A et A->B le transvasement de A vers B.

exemple d'utilisation : 

```
WaterTank.exe 5 3 4
```
