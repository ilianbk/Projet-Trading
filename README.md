# Projet-Trading

# Sommaire

1. [Description du projet](#Description-du-projet)
2. [Prérequis](#Prérequis)
3. [Comment lancer l'application](#Comment-lancer-lapp)
4. [Comment Numérix fonctionne](#Comment-ca-fonctionne)

# Description du projet

Ce projet est une plateforme/site de trading réalisé en C#. Il permet de visualiser le cours des crypto-monnaies en temps réel, d'avoir une estimation du volume, des signaux de trading etc.

Pour ce projet, j'ai utilisé différentes technologies: du C# et API pour le back-end, du .NET pour le frond-end. 

# Prérequis

Avant toute chose, il faut installer .Net core sur votre ordinateur. De plus, il faut créer un compte sur le site cryptocompare.com afin de récuperer la clé pour effectuer les calls API. Enfin, il faut remplacer dans le code ma propre clé par la votre.


# Comment lancer l'application

L'application se lance via le fichier .sln. Le compilateur se lance automatiquement ensuite.


# Comment Numérix fonctionne

L'application affiche une interface graphique en WPF, chaque action qui nécessite une requête de l'API se fait automatiquement si le lien est respecté. Les requêtes validées peuvent être retrouvées dans votre compte cryptocompare.
