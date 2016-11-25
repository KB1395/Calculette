#Calculette

This is our project in **C#** to understand the concept of **object programming**.
The purpose of this program is to be in one Solution with a main project .exe and secundary projects with a lot of tiny .dll ouputs that are used to make our different functions.


#Instru to create "The Program"
- We have to create **four projects** but they have to be in the same solution so we create the project *Calcul_main* as a *ConsoleApplication* and the *Calcul_lib*, *Trigo_lib* and *Computer* as a *bibliothèque de classe* **inside the same solution**.
- :collision:!When we create a new project it's in a new solution each time so we have to create the second one inside the first solution!
- To make a link between the **four project** we have to go in the reference form the main project and add the reference of the Computer project.

#Instru .gitignore

\****/ est necessaire pour indiquer qu'il faut ignorer tout les directory ahead à partit de **Git 8**
<br>Ne pas ignorer les properties ou App.config car dedans s'y trouve le fichier assembly.cs qui est necessaire pour faire tourner le programme.

#Mode d'emploi

- Si vous chargez le programme à partir de \textit{Github}, commencez par générer la solution de tout le projet afin d'être sûr d'avoir produit tout les \textbf{.dll} nécessaires.

- Lancez le terminal. Le programme chargera automatiquement le fichier \textbf{.exe} ainsi que ses différents \textbf{.dll}.

#La Calculette vous propose alors 3 choix possibles:

- Utiliser les différentes fonctions si celles-ci sont déjà connues.

Tapez le nom de la fonction ainsi que les paramètres nécessaires à l'exécution de celle-ci.

exemple: \textit{add 4 9} renverra le résultat \textit{13}

Attention au respect des minuscules ou \textsc{Majuscules}!

- Demander de l'aide afin de consulter les différentes possibilités.

Tapez \textit{help} pour afficher les fonctions

- Sortir du programme.

Tapez \textit{exit}


Une gestion des différentes erreurs à également été mise en place afin d'éviter que l'utilisateur ne fournisse de mauvaises variables ou pas de variables du tout.

#Différentes fonctions

-Adder
-Substractor
-Multiplier
-Sinus
-Cosinus
-Tan



#Contributor
- Puissant Baeyens Victor, 12098, [MisterTarock](https://github.com/MisterTarock)
- De Keyzer  Paolo, 13201, [KB1395](https://github.com/KB1395)


#References

- Our class "Conception et programmation orienté objet"
- To make this Readme https://guides.github.com/features/mastering-markdown/
