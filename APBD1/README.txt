1.Git wykona fast-forward gdy gałąź docelowa nie ma nowych commitów od momentu rozgałęzienia. 
Wtedy historia pozostaje liniowa i nie powstaje merge commit.
Gdy obie gałęzie mają nowe commity, połączone muszą zostać dwie historie i powstaje merge commit, a historia ma rozgałęzienie.
2.Merge zachowuje historię obu gałęzi i tworzy merge commit, 
podczas gdy rebase przenosi commity z jednej gałęzi na drugą tworząc liniową historię zamiast rozgałęzienia.
3.Rozwiązałem konflikt wybierając wersję kodu z gałęzi feature-conflict, następnie nastąpił merge który zastąpił kod na gałęzi main.